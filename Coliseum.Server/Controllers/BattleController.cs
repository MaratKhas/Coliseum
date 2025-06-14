﻿using Coliseum.Modules.Coliseums.Application.Battle.Dto;
using Coliseum.Modules.Coliseums.Application.Battle.Queries.GetJournal;
using Coliseum.Modules.Coliseums.Application.Coliseums.Commands.CreateCommand;
using Microsoft.AspNetCore.Mvc;

namespace Coliseum.WebApi.Controllers
{
    [Route("api/battles")]
    public class BattleController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var result = await Mediator.Send(new GetBattleJournalQuery());
            return Ok(result);
        }

        [HttpPost("create")]
        public async Task<ActionResult> Post([FromBody] CreateBattleDto dto)
        {
            var result = await Mediator.Send(new CreateBattleCommand(dto));
            return Ok(result);
        }
    }
}
