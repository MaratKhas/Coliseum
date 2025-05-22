using Coliseum.Modules.Coliseums.Domain.BattleAreas.Domain;
using System.Collections.Concurrent;
using System.Collections.ObjectModel;

namespace Coliseum.Modules.Coliseums.Infrastructure.Repositories
{
    public class BattleInMemoryRepository : IBattleRepository
    {
        private readonly ConcurrentDictionary<Guid, BattleArea> _battles = new();
        private readonly object _lock = new();

        public void AddBattle(BattleArea battle)
        {
            lock (_lock)
            {
                _battles.TryAdd(battle.Id, battle);
            }
        }

        public IReadOnlyCollection<BattleArea> GetBattles()
        {
            return _battles.Values as ReadOnlyCollection<BattleArea>;
        }

        public BattleArea GetBattle(Guid id)
        {
            var result = _battles.TryGetValue(id, out var battle);

            return battle;
        }
    }
}
