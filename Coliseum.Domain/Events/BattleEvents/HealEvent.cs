using Coliseum.Modules.Coliseums.Domain.Bases;

namespace Coliseum.Modules.Coliseums.Domain.Events.BattleEvents
{
    public class HealEvent : BaseBattleEvent
    {
        public HealEvent(Guid targetId, int heal)
        {
            TargetId = targetId;
            Heal = heal;
        }

        public Guid TargetId { get; set; }

        public int Heal { get; set; }

    }
}
