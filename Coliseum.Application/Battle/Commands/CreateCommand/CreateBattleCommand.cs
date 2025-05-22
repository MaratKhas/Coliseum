using Coliseum.Modules.Coliseums.Domain.BattleAreas.Domain;
using Coliseum.Modules.Coliseums.Infrastructure.Repositories;
using MediatR;

namespace Coliseum.Modules.Coliseums.Application.Coliseums.Commands.CreateCommand
{
    public record CreateBattleCommand : IRequest<Guid>;

    public class CreateBattleCommandHandler(IBattleRepository memoryRepository) : IRequestHandler<CreateBattleCommand, Guid>
    {
        public Task<Guid> Handle(CreateBattleCommand request, CancellationToken cancellationToken)
        {
            var battle = BattleArea.Create();
            memoryRepository.AddBattle(battle);

            return Task.FromResult(battle.Id);
        }
    }
}
