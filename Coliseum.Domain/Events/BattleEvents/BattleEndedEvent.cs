using Coliseum.Modules.Coliseums.Domain.Bases;

namespace Coliseum.Modules.Coliseums.Domain.BattleEvents
{
    public class BattleEndedEvent : BaseBattleEvent
    {
        public DateTime BattleEndTime { get; set; }

        public BattleEndedEvent(Guid battleId, DateTime dateEnd) : base(battleId)
        {
            BattleEndTime = dateEnd;
        }
    }
}
