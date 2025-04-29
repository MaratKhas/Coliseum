using Coliseum.BuildingBlocks.Domain;

namespace Coliseum.Domain.Bases
{
    public abstract class BaseBattleEvent : IDomainEvent
    {
        public DateTime EventDate { get; } = DateTime.Now;
    }
}
