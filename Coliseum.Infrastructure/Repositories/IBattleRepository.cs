using Coliseum.Modules.Coliseums.Domain.BattleAreas.Domain;

namespace Coliseum.Modules.Coliseums.Infrastructure.Repositories
{
    public interface IBattleRepository
    {
        void AddBattle(BattleArea battle);

        IReadOnlyCollection<BattleArea> GetBattles();

        BattleArea GetBattle(Guid id);
    }
}