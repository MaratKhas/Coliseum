using Coliseum.Modules.Coliseums.Domain.Bases;
using Coliseum.Modules.Coliseums.Domain.BattleAreas.Domain;
using Coliseum.Modules.Coliseums.Domain.Warriors;
using MediatR;

namespace Coliseum.Modules.Coliseums.Application.Coliseums.Commands.TestCommand
{
    public record TestBattleCommand : IRequest;

    public class TestBattleCommandHandler : IRequestHandler<TestBattleCommand>
    {
        public async Task Handle(TestBattleCommand request, CancellationToken cancellationToken)
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
