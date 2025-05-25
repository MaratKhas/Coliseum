using Coliseum.Modules.Coliseums.Application.Battle.Dto;
using Coliseum.Modules.Coliseums.Infrastructure.Repositories;
using MediatR;

namespace Coliseum.Modules.Coliseums.Application.Battle.Queries.GetJournal
{
    public record GetBattleJournalQuery : IRequest<BattleJournalDto>;

    public class GetBattleJournalQueryHandler(IBattleRepository repository) : IRequestHandler<GetBattleJournalQuery, BattleJournalDto>
    {
        public Task<BattleJournalDto> Handle(GetBattleJournalQuery request, CancellationToken cancellationToken)
        {
            var result = new BattleJournalDto();
            var battles = repository.GetBattles();
            foreach (var battle in battles)
            {
                result.Items.Add(new BattleJournalItemDto()
                {
                    Id = battle.Id,
                    Name = battle.Name,
                });
            }

            return Task.FromResult(result);
        }
    }
}
