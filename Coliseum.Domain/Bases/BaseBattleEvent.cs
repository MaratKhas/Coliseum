using Coliseum.BuildingBlocks.Domain;

namespace Coliseum.Modules.Coliseums.Domain.Bases
{
    public abstract class BaseBattleEvent : IDomainEvent
    {
        public DateTime EventDate { get; } = DateTime.Now;
    }
}
