using Coliseum.Modules.Coliseums.Domain.Events.BattleEvents;
using MediatR;

namespace Coliseum.Modules.Coliseums.Application.Battle.EventHandlers
{
    internal class DamageTakenEventHandler : INotificationHandler<DamageTakenEvent>
    {
        public Task Handle(DamageTakenEvent notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
