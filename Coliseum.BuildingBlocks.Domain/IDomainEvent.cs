using MediatR;

namespace Coliseum.BuildingBlocks.Domain
{
    public interface IDomainEvent : INotification
    {
        DateTime EventDate { get; }
    }
}
