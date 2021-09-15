using GrupoChat.Data;
using GrupoChat.Hubs;
using GrupoChat.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrupoChat.Controllers
{
    [Authorize]
    
    public class ChatController : Controller
    {
        public readonly UserManager<AppUser> _userManager;
        public readonly Context _context;

        public ChatController(UserManager<AppUser> userManager, Context context)
        {
            _userManager = userManager;
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            ViewBag.CurrentUserName = currentUser.UserName;
            ViewBag.NomeUsuario = currentUser.NomeUsuario; 
            ViewBag.Messages = _context.Message.Where(m => m.TargetName == null).ToList();
            return View();
        }

        public async Task<IActionResult> Private()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            List<AppUser> allUsers = _context.Users.Where(u => u.UserName != currentUser.UserName).ToList();
            var current = await _userManager.GetUserAsync(User);
            ViewBag.NomeUsuario = currentUser.NomeUsuario;
            ViewBag.CurrentUser = current;
            return View(allUsers);

        }
        public async Task<IActionResult> PrivateMessage(string id)
        {
            var current = await _userManager.GetUserAsync(User);
            var target = await _userManager.FindByNameAsync(id);
            var sentMessages = _context.Message.Where(m => m.UserName == current.UserName && m.TargetName == target.UserName).ToList();
            var receivedMessages = _context.Message.Where(m => m.UserName == target.UserName && m.TargetName == current.UserName).ToList();
            var messages = sentMessages.Concat(receivedMessages).ToList();
            ViewBag.NomeUsuario = current.NomeUsuario;
            ViewBag.Messages = messages;
            ViewBag.CurrentUser = current;
            ViewBag.TargetUser = target;
            
            return View();


        }

        public async Task<IActionResult> SendMessage(string text, [FromServices] IHubContext<ChatHub> chat)
        {
            var sender = await _userManager.GetUserAsync(User);
            Message message = new Message
            {   Text = text,
                UserName = User.Identity.Name,
                NomeUsuario = sender.NomeUsuario,
                UserId = sender.Id,
                Datetime = DateTime.Now
            };

            _context.Message.Add(message);
            _context.SaveChanges();
            await chat.Clients.All.SendAsync("ReceiveMessage", message);
            return Ok();
            
        }

            


    }
}
