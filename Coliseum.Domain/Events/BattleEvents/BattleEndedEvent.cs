using Coliseum.Modules.Coliseums.Domain.Bases;

namespace Coliseum.Modules.Coliseums.Domain.BattleEvents
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
