using Coliseum.Modules.Coliseums.Application.Coliseums.Commands.TestCommand;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Coliseum.WebApi.Controllers
{
    [ApiController]
    public class TestController : BaseController
    {
        [HttpGet("test")]
        public async Task Test(CancellationToken cancellationToken)
        {
            await Mediator.Send(new TestBattleCommand());
        }
    }
}
