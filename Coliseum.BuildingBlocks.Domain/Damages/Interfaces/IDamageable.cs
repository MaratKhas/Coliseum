namespace Coliseum.BuildingBlocks.Domain.Damages.Interfaces
{
    public interface IDamageable
    {
        Guid Id { get; }

        void GetDamage(IDamage damage);
    }
}
