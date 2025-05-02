using Coliseum.Modules.Coliseums.Domain.Events.BattleEvents;
using MediatR;

namespace Coliseum.Modules.Coliseums.Application.Battle.EventHandlers
{
    internal class UseUltimateEventHandler : INotificationHandler<UseUltimateEvent>
    {
        public Task Handle(UseUltimateEvent notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
