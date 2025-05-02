using Coliseum.Modules.Coliseums.Domain.Events.BattleEvents;
using MediatR;
using System.Diagnostics;

namespace Coliseum.Modules.Coliseums.Application.Battle.EventHandlers
{
    internal class BattleStartedEventHandler : INotificationHandler<BattleStartedEvent>
    {
        public async Task Handle(BattleStartedEvent notification, CancellationToken cancellationToken)
        {
            var message = $"Битва {notification.BattleId} начинается {notification.BattleStartTime}";
            Debug.WriteLine(message);
        }
    }
}
