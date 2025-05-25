using Coliseum.Modules.Coliseums.Application.Battle.Dto;
using Coliseum.Modules.Coliseums.Domain.BattleAreas.Domain;
using Coliseum.Modules.Coliseums.Infrastructure.Repositories;
using MediatR;

namespace Coliseum.Modules.Coliseums.Application.Coliseums.Commands.CreateCommand
{
    public record CreateBattleCommand(CreateBattleDto Model) : IRequest<Guid>;

    public class CreateBattleCommandHandler(IBattleRepository memoryRepository) : IRequestHandler<CreateBattleCommand, Guid>
    {
        public Task<Guid> Handle(CreateBattleCommand request, CancellationToken cancellationToken)
        {
            var battle = BattleArea.Create(request.Model.Name);

            memoryRepository.AddBattle(battle);

            return Task.FromResult(battle.Id);
        }
    }
}
