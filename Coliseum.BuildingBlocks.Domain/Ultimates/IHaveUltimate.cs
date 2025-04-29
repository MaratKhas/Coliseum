namespace Coliseum.BuildingBlocks.Domain.Ultimates
{
    public interface IHaveUltimate
    {
        void UseUltimate();
    }

    public interface IHaveUltimate<T> : IHaveUltimate where T : IUltimate
    {
        T Ultimate { get; }
    }

    public interface IHaveHealingUltimate<T> : IHaveUltimate<T> where T : IUltimate { }

    public interface IHaveAttackUltimate<T> : IHaveUltimate<T> where T : IUltimate { }

}
