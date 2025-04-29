using Coliseum.Domain.Events.BattleEvents;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coliseum.Application.Battle.EventHandlers
{
    internal class UseUltimateEventHandler : INotificationHandler<UseUltimateEvent>
    {
        public Task Handle(UseUltimateEvent notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
