using Coliseum.Modules.Coliseums.Domain.Bases;

namespace Coliseum.Modules.Coliseums.Domain.Events.BattleEvents
{
    public class BattleStartedEvent : BaseBattleEvent
    {
        public Guid BattleId { get; set; }

        public DateTime BattleStartTime { get; set; }

        public BattleStartedEvent(Guid id, DateTime dateStart)
        {
            BattleId = id;
            BattleStartTime = dateStart;
        }
    }
}
