using Coliseum.BuildingBlocks.Domain.Damages.Interfaces;
using Coliseum.BuildingBlocks.Domain.Enums;

namespace Coliseum.Modules.Coliseums.Domain.Bases
{
    public abstract class BaseDamage : IDamage
    {
        public BaseDamage(int damage)
        {
            DamageValue = damage;
        }

        public int DamageValue { get; set; }

        public abstract DamageTypeEnum DamageType { get; }

        public abstract short SpreadDamage { get; }

        public int GetDamageValue()
        {
            return DamageValue * SpreadDamage;
        }
    }
}
