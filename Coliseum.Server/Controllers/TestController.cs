using Coliseum.Domain.Bases;
using Coliseum.Domain.Warriors;
using Microsoft.AspNetCore.Mvc;
using Modules.Coliseums.Domain.Coliseums.Domain;

namespace Coliseum.WebApi.Controllers
{
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("test")]
        public async Task Test( CancellationToken cancellationToken)
        {
            var coliseum = BattleArea.Create();

            var gladiators = new List<BaseWarrior>() {
                Gladiator.Create("Гладиатор 1",30, 400),
                Gladiator.Create("Гладиатор 2",40, 500),
                Gladiator.Create("Гладиатор 3",50, 600),
            };

            coliseum.AddWarriorsToLeftWarriors(gladiators);

            gladiators = new List<BaseWarrior>() {
                Gladiator.Create("Гладиатор 4",40, 300),
                Gladiator.Create("Гладиатор 5",30, 400),
                Gladiator.Create("Гладиатор 6",50, 700),
            };

            coliseum.AddWarriorsToRightWarriors(gladiators);

            await coliseum.StartBattleAsync(cancellationToken);
        }
    }
}
