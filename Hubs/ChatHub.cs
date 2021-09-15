using GrupoChat.Data;
using GrupoChat.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrupoChat.Hubs
{
    public class ChatHub : Hub
    {
        Context _context;
        IHttpContextAccessor _httpContextAccessor;
        public ChatHub(Context context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
           
        }
        public async Task SendMessage(Message m)
        {
            m.Datetime = DateTime.Now;

            if (m.UserName != Context.User.Identity.Name) return;
            var user = _context.Users.FirstOrDefault(u => u.UserName == m.UserName);
            if (user == null) return;
            _context.Message.Add(m);
            _context.SaveChanges();
            
            Message returnMessage = new Message
            {
              
                UserName = m.UserName,
                Text = m.Text,
                NomeUsuario = m.NomeUsuario,
                Datetime = m.Datetime
               
            };

            await Clients.All.SendAsync("ReceiveMessage", returnMessage);
        }

        public async Task SendPrivateMessage(Message m)
        {
            m.Datetime = DateTime.Now;
            if (m.UserName != Context.User.Identity.Name) return;
            var user = _context.Users.FirstOrDefault(u => u.UserName == m.UserName);
            var target = _context.Users.FirstOrDefault(u => u.UserName == m.TargetName);
            if (target == null) return;
            m.UserId = user.Id;
            m.targetId = target.Id;
            m.Datetime = m.Datetime;
            _context.Message.Add(m);
            _context.SaveChanges();
            Message returnMessage = new Message
            {
                UserName = m.UserName,
                Text = m.Text,
                NomeUsuario= m.NomeUsuario,
                Datetime = m.Datetime
            };

            var currentName = Context.User.Identity.Name;
            var targetName = m.TargetName;
            var group = currentName.Length > targetName.Length ? $"{targetName}{currentName}" : $"{currentName}{targetName}";

            await Clients.Group(group).SendAsync("PrivateMessage", returnMessage);
        }

        public string GetConnection() => Context.ConnectionId;

        public Task JoinPrivate(string targetName)
        {
            var currentName = Context.User.Identity.Name;
            var group = currentName.Length > targetName.Length ? $"{targetName}{currentName}" : $"{currentName}{targetName}";
            return Groups.AddToGroupAsync(Context.ConnectionId, group);
        }
        public Task LeavePrivate(string targetName)
        {
            var currentName = Context.User.Identity.Name;
            var group = currentName.Length > targetName.Length ? $"{targetName}{currentName}" : $"{currentName}{targetName}";
            return Groups.RemoveFromGroupAsync(Context.ConnectionId, group);
        }
    }
}
