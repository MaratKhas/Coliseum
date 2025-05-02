using Coliseum.Modules.Coliseums.Domain.Events.BattleEvents;
using MediatR;

namespace Coliseum.Modules.Coliseums.Application.Battle.EventHandlers
{
    internal class HealEventHandler : INotificationHandler<HealEvent>
    {
        public Task Handle(HealEvent notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
