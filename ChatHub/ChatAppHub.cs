using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace ChatApp.Hubs
{
    public class ChatAppHub : Hub
    {
        public async Task SendMessage(string userName, string userProfilePic, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", userName, userProfilePic, message);
        }

        public override async Task OnConnectedAsync()
        {
            await Clients.All.SendAsync("ReceiveMessage", "System", null, $"{Context.ConnectionId} connected.");
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            await Clients.All.SendAsync("ReceiveMessage", "System", null, $"{Context.ConnectionId} disconnected.");
            await base.OnDisconnectedAsync(exception);
        }
    }
}
