using Coliseum.BuildingBlocks.Domain.Damages.Interfaces;
using Coliseum.Modules.Coliseums.Domain.Bases;

namespace Coliseum.Modules.Coliseums.Domain.Events.BattleEvents
{
    public class AttackEvent : BaseBattleEvent
    {
        public AttackEvent(Guid attackerId, Guid targetId, IDamage damage)
        {
            AttackerId = attackerId;
            TargetId = targetId;
            Damage = damage;
        }

        public Guid AttackerId { get; set; }

        public Guid TargetId { get; set; }

        public IDamage Damage { get; set; }

    }
}
