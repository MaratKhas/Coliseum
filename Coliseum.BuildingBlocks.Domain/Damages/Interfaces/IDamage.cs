using Coliseum.BuildingBlocks.Domain.Enums;

namespace Coliseum.BuildingBlocks.Domain.Damages.Interfaces
{
    public interface IDamage
    {
        DamageTypeEnum DamageType { get; }

        int GetDamageValue();
    }
}
