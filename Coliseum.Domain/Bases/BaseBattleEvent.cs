using Coliseum.BuildingBlocks.Domain;

namespace Coliseum.Modules.Coliseums.Domain.Bases
{
    public abstract class BaseBattleEvent : IDomainEvent
    {
        public BaseBattleEvent(Guid id)
        {
            BattleId = id;
        }

        public Guid BattleId { get; set; }

        public DateTime EventDate { get; } = DateTime.Now;
    }
}
