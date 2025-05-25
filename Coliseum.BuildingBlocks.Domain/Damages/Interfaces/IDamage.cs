using Coliseum.BuildingBlocks.Domain.Enums;

namespace Coliseum.BuildingBlocks.Domain.Damages.Interfaces
{
    public interface IDamage
    {
        DamageType DamageType { get; }

        int GetDamageValue();
    }
}
