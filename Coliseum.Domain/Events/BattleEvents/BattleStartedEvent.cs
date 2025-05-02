using Coliseum.Modules.Coliseums.Domain.Bases;

namespace Coliseum.Modules.Coliseums.Domain.Events.BattleEvents
{
    public class BattleStartedEvent : BaseBattleEvent
    {
        public DateTime BattleStartTime { get; set; }

        public BattleStartedEvent(Guid battleId, DateTime dateStart) : base(battleId)
        {
            BattleStartTime = dateStart;
        }
    }
}
