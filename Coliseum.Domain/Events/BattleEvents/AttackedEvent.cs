using Coliseum.BuildingBlocks.Domain.Damages.Interfaces;
using Coliseum.Modules.Coliseums.Domain.Bases;

namespace Coliseum.Modules.Coliseums.Domain.Events.BattleEvents
{
    public class AttackedEvent : BaseBattleEvent
    {
        public AttackedEvent(Guid battleId, Guid attackerId, Guid targetId, IDamage damage) : base(battleId)
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
