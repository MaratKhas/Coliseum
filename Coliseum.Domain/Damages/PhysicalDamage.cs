using Coliseum.BuildingBlocks.Domain.Enums;
using Coliseum.Domain.Bases;

namespace Coliseum.Domain.Damages
{
    public class PhysicalDamage : BaseDamage
    {
        public PhysicalDamage(int damage) : base(damage)
        {
        }

        public override DamageTypeEnum DamageType => DamageTypeEnum.Physical;

        public override short SpreadDamage => 20;
    }
}
