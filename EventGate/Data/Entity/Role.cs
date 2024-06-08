using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventGate.Data.Entity
{
    public class Role : IdentityRole
    {
        [Key]
        public string Id { get; set; }

        //public new string Name { get; set; }
        [NotMapped]
        public Roles Name { get; set; }

        //public ICollection<User> Users { get; set; }
    }

    [Keyless]
    public class Roles
    {
        public const string ADMIN = "Admin";
        public const string STAFF = "Staff";
        public const string CLUB = "Club";
        //public const string SPONSOR = "Sponsor";
        public const string MEMBER = "Member";
    }
}