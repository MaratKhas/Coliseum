using Coliseum.Modules.Coliseums.Domain.Events.BattleEvents;
using MediatR;
using System.Diagnostics;

namespace Coliseum.Modules.Coliseums.Application.Battle.EventHandlers
{
    public class DamageTakenEventHandler() : INotificationHandler<DamageTakenEvent>
    {
        public async Task Handle(DamageTakenEvent notification, CancellationToken cancellationToken)
        {
            var message = $"защищающийся {notification.WarriorId} получает урон {notification.DamageAmount}, тип урона {notification.DamageType}";
            Debug.WriteLine(message); 
        }
    }
}
