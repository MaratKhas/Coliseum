using Coliseum.BuildingBlocks.Domain.Enums;
using Coliseum.Modules.Coliseums.Domain.Bases;

namespace Coliseum.Modules.Coliseums.Domain.Damages
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
