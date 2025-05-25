using Coliseum.BuildingBlocks.Domain.Enums;
using Coliseum.Modules.Coliseums.Domain.Bases;

namespace Coliseum.Modules.Coliseums.Domain.Damages
{
    public class PhysicalDamage : BaseDamage
    {
        public PhysicalDamage(int damage) : base(damage)
        {
        }

        public override DamageType DamageType => DamageType.Physical;

        public override double SpreadDamage => 0.2;
    }
}
