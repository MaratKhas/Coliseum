using Coliseum.Domain.Events.BattleEvents;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coliseum.Application.Battle.EventHandlers
{
    internal class DefeatEventHandler : INotificationHandler<DefeatEvent>
    {
        public Task Handle(DefeatEvent notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
