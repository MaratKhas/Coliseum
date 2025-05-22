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
            var test = repository.GetBattles();
            foreach (var battles in test)
            {
                result.Items.Add(new BattleJournalItemDto()
                {
                    Id = battles.Id,
                });
            }

            return Task.FromResult(result);
        }
    }
}
