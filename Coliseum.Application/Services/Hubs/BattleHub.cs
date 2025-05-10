using Microsoft.AspNetCore.SignalR;

namespace Coliseum.Modules.Coliseums.Application.Services.Hubs
{
    public class BattleHub : Hub
    {
        public async Task JoinBattleGroup(Guid battleId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, battleId.ToString());
            await Clients.Caller.SendAsync("Connected", $"Подключение к битве {battleId} успешно");
        }

        public async Task LeaveBattleGroup(Guid battleId)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, battleId.ToString());
        }
    }
}
