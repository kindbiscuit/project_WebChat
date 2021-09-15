﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using GrupoChat.Areas.Identity.Pages.Account;

namespace GrupoChat.Models
{
    public class Message
    {
       
        public int Id { get; set; }
        public string UserName { get; set; }
        public string TargetName { get; set; }

        [Required]
        public string Text { get; set; }
        public DateTime Datetime { get; set; }
        public string NomeUsuario { get; set; }
        
        public string UserId { get; set; }
        public AppUser appUser { get; set; }
        public string targetId { get; set; }
        public AppUser targetUser { get; set; }
       
        
       
        


    }
}
