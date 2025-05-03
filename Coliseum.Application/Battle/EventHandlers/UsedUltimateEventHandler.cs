using Coliseum.Modules.Coliseums.Domain.Events.BattleEvents;
using MediatR;

namespace Coliseum.Modules.Coliseums.Application.Battle.EventHandlers
{
    internal class UsedUltimateEventHandler : INotificationHandler<UsedUltimateEvent>
    {
        public Task Handle(UsedUltimateEvent notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
