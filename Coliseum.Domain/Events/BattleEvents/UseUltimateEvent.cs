using Coliseum.Modules.Coliseums.Domain.Bases;

namespace Coliseum.Modules.Coliseums.Domain.Events.BattleEvents
{
    public class UseUltimateEvent : BaseBattleEvent
    {
        public UseUltimateEvent(Guid battleId) : base(battleId)
        {

        }
    }
}
