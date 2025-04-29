using Coliseum.BuildingBlocks.Domain.Enums;
using Coliseum.Domain.Bases;

namespace Coliseum.Domain.Events.BattleEvents
{
    public class DamageTakenEvent : BaseBattleEvent
    {
        public Guid WarriorId { get; }
        public int DamageAmount { get; }
        public DamageTypeEnum DamageType { get; }

        public DamageTakenEvent(Guid warriorId, int damageAmount, DamageTypeEnum damageType)
        {
            WarriorId = warriorId;
            DamageAmount = damageAmount;
            DamageType = damageType;
        }
    }
}
