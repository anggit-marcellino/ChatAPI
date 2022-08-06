using Microsoft.EntityFrameworkCore;
using DomainChat.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DomainChat.Contexts
{
    public class ChatDbContext : IdentityDbContext
    {
        public ChatDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}
