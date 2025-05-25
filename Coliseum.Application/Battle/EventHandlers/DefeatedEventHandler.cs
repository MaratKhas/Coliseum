using Coliseum.Modules.Coliseums.Domain.Events.BattleEvents;
using MediatR;
using System.Diagnostics;

namespace Coliseum.Modules.Coliseums.Application.Battle.EventHandlers
{
    internal class DefeatedEventHandler : INotificationHandler<DefeatedEvent>
    {
        public async Task Handle(DefeatedEvent notification, CancellationToken cancellationToken)
        {
            var message = $"воин {notification.WarriorId} погиб , дата {notification.EventDate}";
            Debug.WriteLine(message);
        }
    }
}
