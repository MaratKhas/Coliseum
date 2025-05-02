using Coliseum.Modules.Coliseums.Domain.Bases;

namespace Coliseum.Modules.Coliseums.Domain.Events.BattleEvents
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
