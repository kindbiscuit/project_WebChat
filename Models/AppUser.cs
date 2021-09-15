using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GrupoChat.Models
{
    public class AppUser : IdentityUser
    {
        public List<Message> Messages { get; set; }
    
        public string NomeUsuario { get; set; }
        
    }
}
