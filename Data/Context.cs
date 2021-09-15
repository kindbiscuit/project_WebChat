using GrupoChat.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrupoChat.Data
{
    public class Context:IdentityDbContext<AppUser>
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            builder.Entity<Message>()
                .HasOne<AppUser>(a => a.appUser)
                .WithMany(d => d.Messages)
                .HasForeignKey(d => d.UserId);
            //builder.Entity<Message>()
            //   .HasOne<AppUser>(a => a.targetNome)
            //   .WithMany(d => d.Messages)
            //   .HasForeignKey(d => d.NomeUsuario);



        }
        public DbSet<Message> Message { get; set; }
    }
}
