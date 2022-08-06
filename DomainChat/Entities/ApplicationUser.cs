using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomainChat.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [Column(TypeName = "varchar(150)")]
        public string FirstName { get; set; }

        [Column(TypeName = "varchar(150)")]
        public string LastName { get; set; }
        public bool IsOnline { get; set; }

    }
}
