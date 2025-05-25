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

        public abstract DamageType DamageType { get; }

        public abstract double SpreadDamage { get; }

        public int GetDamageValue()
        {
            double minMultiplier = 1.0 - SpreadDamage;
            double maxMultiplier = 1.0 + SpreadDamage;

            var damageMultiplier = Random.Shared.NextDouble() * (maxMultiplier - minMultiplier) + minMultiplier;

            var result = (int)(DamageValue * damageMultiplier);

            return Math.Max(1, result);
        }
    }
}
