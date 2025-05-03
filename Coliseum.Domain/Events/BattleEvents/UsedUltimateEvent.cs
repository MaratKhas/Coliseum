using Coliseum.Modules.Coliseums.Domain.Bases;

namespace Coliseum.Modules.Coliseums.Domain.Events.BattleEvents
{
    public class UsedUltimateEvent : BaseBattleEvent
    {
        public UsedUltimateEvent(Guid battleId) : base(battleId)
        {

        }
    }
}
