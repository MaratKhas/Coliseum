using Coliseum.BuildingBlocks.Domain.Enums;
using Coliseum.Modules.Coliseums.Domain.Bases;

namespace Coliseum.Modules.Coliseums.Domain.Events.BattleEvents
{
    public class DamageTakenEvent : BaseBattleEvent
    {
        public Guid WarriorId { get; }
        public int DamageAmount { get; }
        public DamageType DamageType { get; }

        public DamageTakenEvent(Guid battleId, Guid warriorId, int damageAmount, DamageType damageType) : base(battleId)
        {
            WarriorId = warriorId;
            DamageAmount = damageAmount;
            DamageType = damageType;
        }
    }
}
