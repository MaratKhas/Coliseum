using Coliseum.Domain.Events.BattleEvents;
using MediatR;
using System.Diagnostics;

namespace Coliseum.Application.Battle.EventHandlers
{
    public class AttackEventHandler : INotificationHandler<AttackEvent>
    {
        public async Task Handle(AttackEvent notification, CancellationToken cancellationToken)
        {
            var message = $"атакующий {notification.AttackerId} получающий урон {notification.TargetId} урон {notification.Damage} дата {notification.EventDate}";
            Debug.WriteLine(message);
        }
    }
}
