using Microsoft.AspNetCore.SignalR;
 
namespace SignalRProject
{
    public class ChatHub : Hub
    {
        public async Task Send(string message)
        {
            await this.Clients.All.SendAsync("Receive", message);
        }
    }
}