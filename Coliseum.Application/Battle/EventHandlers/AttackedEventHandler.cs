using Coliseum.Modules.Coliseums.Domain.Events.BattleEvents;
using MediatR;
using System.Diagnostics;

namespace Coliseum.Modules.Coliseums.Application.Battle.EventHandlers
{
    public class AttackedEventHandler : INotificationHandler<AttackedEvent>
    {
        public async Task Handle(AttackedEvent notification, CancellationToken cancellationToken)
        {
            var message = $"атакующий {notification.AttackerId} атакует {notification.TargetId} дата {notification.EventDate}";
            Debug.WriteLine(message);
        }
    }
}
