using Coliseum.Modules.Coliseums.Domain.BattleEvents;
using MediatR;

namespace Coliseum.Modules.Coliseums.Application.Battle.EventHandlers
{
    internal class BattleEndedEventHandler : INotificationHandler<BattleEndedEvent>
    {
        public Task Handle(BattleEndedEvent notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
