using Coliseum.BuildingBlocks.Domain;
using Coliseum.Modules.Coliseums.Domain.Bases;
using Coliseum.Modules.Coliseums.Domain.BattleAreas.Domain;
using Coliseum.Modules.Coliseums.Domain.Warriors.Gladiators;
using Coliseum.Modules.Coliseums.Domain.Warriors.Interfaces;
using MediatR;
using Coliseum.BuildingBlocks.Domain.Enums;

namespace Coliseum.Modules.Coliseums.Application.Coliseums.Commands.TestCommand
{
    public record TestBattleCommand : IRequest;

    public class TestBattleCommandHandler(IDomainEventObserver observer, IWarriorFactory factory) : IRequestHandler<TestBattleCommand>
    {
        public async Task Handle(TestBattleCommand request, CancellationToken cancellationToken)
        {
            var coliseum = BattleArea.Create("Тест");

            var gladiators = new List<BaseWarrior>() {
                factory.CreateWarrior(WarriorType.Gladiator ,"Гладиатор 1",30, 400),
                factory.CreateWarrior(WarriorType.Gladiator ,"Гладиатор 2",40, 500),
                factory.CreateWarrior(WarriorType.Gladiator ,"Гладиатор 3",50, 600)
            };

            coliseum.AddWarriorsToLeftWarriors(gladiators);

            gladiators.ForEach(f => f.RegisterObserver(observer));


            gladiators = new List<BaseWarrior>() {
                factory.CreateWarrior(WarriorType.Gladiator ,"Гладиатор 4",40, 300),
                factory.CreateWarrior(WarriorType.Gladiator ,"Гладиатор 5",30, 400),
                factory.CreateWarrior(WarriorType.Gladiator ,"Гладиатор 6",50, 700)
            };

            coliseum.AddWarriorsToRightWarriors(gladiators);

            coliseum.RegisterObserver(observer);

            gladiators.ForEach(f => f.RegisterObserver(observer));
            await coliseum.StartBattleAsync(cancellationToken);
        }
    }
}
