using Coliseum.Modules.Coliseums.Domain.Events.BattleEvents;
using MediatR;

namespace Coliseum.Modules.Coliseums.Application.Battle.EventHandlers
{
    internal class DefeatedEventHandler : INotificationHandler<DefeatedEvent>
    {
        public Task Handle(DefeatedEvent notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
