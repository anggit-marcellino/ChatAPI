using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace ChatAPI.Hubs
{
    public class ChatHub : Hub
    {
        public Task SendMessage1(string user, string message)               
        {
            return Clients.All.SendAsync("ReceiveOne", user, message);     
        }
    }
}
