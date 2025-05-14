using Coliseum.Modules.Coliseums.Application.Coliseums.Commands.TestCommand;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Coliseum.WebApi.Controllers
{
    [ApiController]
    public class TestController : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        [HttpGet("test")]
        public async Task Test(CancellationToken cancellationToken)
        {
            await Mediator.Send(new TestBattleCommand());
        }
    }
}
