using Coliseum.BuildingBlocks.Domain;
using Coliseum.Modules.Coliseums.Domain.Bases;
using Coliseum.Modules.Coliseums.Domain.BattleAreas.Domain;
using Coliseum.Modules.Coliseums.Domain.Warriors;
using MediatR;

namespace Coliseum.Modules.Coliseums.Application.Coliseums.Commands.TestCommand
{
    public record TestBattleCommand : IRequest;

    public class TestBattleCommandHandler(IDomainEventObserver observer) : IRequestHandler<TestBattleCommand>
    {
        public async Task Handle(TestBattleCommand request, CancellationToken cancellationToken)
        {
            var coliseum = BattleArea.Create();
            // Entity.ConfigureObserver()

            var gladiators = new List<BaseWarrior>() {
                Gladiator.Create(coliseum.Id, "Гладиатор 1",30, 400),
                Gladiator.Create(coliseum.Id,"Гладиатор 2",40, 500),
                Gladiator.Create(coliseum.Id,"Гладиатор 3",50, 600),
            };

            coliseum.AddWarriorsToLeftWarriors(gladiators);

            gladiators.ForEach(f => f.RegisterObserver(observer));


            gladiators = new List<BaseWarrior>() {
                Gladiator.Create(coliseum.Id,"Гладиатор 4",40, 300),
                Gladiator.Create(coliseum.Id,"Гладиатор 5",30, 400),
                Gladiator.Create(coliseum.Id,"Гладиатор 6",50, 700),
            };

            coliseum.AddWarriorsToRightWarriors(gladiators);

            coliseum.RegisterObserver(observer);

            gladiators.ForEach(f => f.RegisterObserver(observer));
            await coliseum.StartBattleAsync(cancellationToken);
        }
    }
}
