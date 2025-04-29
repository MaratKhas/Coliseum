using Coliseum.Domain.Bases;

namespace Coliseum.Domain.Events.BattleEvents
{
    public class BattleEndedEvent : BaseBattleEvent
    {
        public Guid BattleId { get; set; }

        public DateTime BattleEndTime { get; set; }

        public BattleEndedEvent(Guid id, DateTime dateEnd)
        {
            BattleId = id;
            BattleEndTime = dateEnd;
        }
    }
}
