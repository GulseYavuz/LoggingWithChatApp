using Microsoft.AspNetCore.SignalR;
using Serilog;
namespace LoggingWithChatApp.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            Log.Information("{User} sent message: {Message}", user, message);
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
