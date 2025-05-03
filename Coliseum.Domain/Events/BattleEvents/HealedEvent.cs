using Coliseum.Modules.Coliseums.Domain.Bases;

namespace Coliseum.Modules.Coliseums.Domain.Events.BattleEvents
{
    public class HealedEvent : BaseBattleEvent
    {
        public HealedEvent(Guid battleId, Guid targetId, int heal) : base(battleId)
        {
            TargetId = targetId;
            Heal = heal;
        }

        public Guid TargetId { get; set; }

        public int Heal { get; set; }

    }
}
