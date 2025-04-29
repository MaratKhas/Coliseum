using Coliseum.Domain.Bases;

namespace Coliseum.Domain.Events.BattleEvents
{
    public class DefeatEvent : BaseBattleEvent
    {
        public Guid WarriorId { get; set; }

        public DefeatEvent(Guid warriorId)
        {
            WarriorId = warriorId;
        }
    }
}
