using Coliseum.Modules.Coliseums.Domain.Bases;

namespace Coliseum.Modules.Coliseums.Domain.Events.BattleEvents
{
    public class DefeatedEvent : BaseBattleEvent
    {
        public Guid WarriorId { get; set; }

        public DefeatedEvent(Guid battleId, Guid warriorId) : base(battleId)
        {
            WarriorId = warriorId;
        }
    }
}
