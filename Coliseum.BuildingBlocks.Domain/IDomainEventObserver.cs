namespace Coliseum.BuildingBlocks.Domain
{
    public interface IDomainEventObserver
    {
        Task HandleEvent(IDomainEvent @event);
    }
}
