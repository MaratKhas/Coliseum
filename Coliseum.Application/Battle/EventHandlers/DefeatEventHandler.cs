using Coliseum.Modules.Coliseums.Domain.Events.BattleEvents;
using MediatR;

namespace Coliseum.Modules.Coliseums.Application.Battle.EventHandlers
{
    internal class DefeatEventHandler : INotificationHandler<DefeatEvent>
    {
        public Task Handle(DefeatEvent notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
