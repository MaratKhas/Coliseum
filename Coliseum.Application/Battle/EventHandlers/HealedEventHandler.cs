using Coliseum.Modules.Coliseums.Domain.Events.BattleEvents;
using MediatR;

namespace Coliseum.Modules.Coliseums.Application.Battle.EventHandlers
{
    internal class HealedEventHandler : INotificationHandler<HealedEvent>
    {
        public Task Handle(HealedEvent notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
