using Coliseum.BuildingBlocks.Domain;
using MediatR;
using System.Diagnostics;

namespace Coliseum.Modules.Coliseums.Infrastructure.DomainEventDespatcher
{
    public class DomainEventRealTimeDespatcher(IMediator mediator) : IDomainEventObserver
    {
        public async Task HandleEvent(IDomainEvent @event)
        {
            Debug.WriteLine(@event.EventDate);
            await mediator.Publish(@event);
        }
    }
}
