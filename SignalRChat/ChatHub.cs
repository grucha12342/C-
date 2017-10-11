using System;
using System.Web;
using Microsoft.AspNet.SignalR;
namespace SignalRChat
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            string message_jp;
            message_jp = message + "jp";
            Clients.All.broadcastMessage(name, message_jp);
        }
    }
}