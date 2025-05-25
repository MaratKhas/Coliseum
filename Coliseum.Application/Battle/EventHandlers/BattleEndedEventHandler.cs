using Coliseum.Modules.Coliseums.Domain.BattleEvents;
using MediatR;
using System.Diagnostics;

namespace Coliseum.Modules.Coliseums.Application.Battle.EventHandlers
{
    internal class BattleEndedEventHandler : INotificationHandler<BattleEndedEvent>
    {
        public async Task Handle(BattleEndedEvent notification, CancellationToken cancellationToken)
        {
            var message = $"битва {notification.BattleId} закончилась,  дата {notification.EventDate}";
            Debug.WriteLine(message);
        }
    }
}
