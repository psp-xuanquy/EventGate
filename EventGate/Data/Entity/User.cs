using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventGate.Data.Entity
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
        public string Avatar { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string IdentityCard { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public ICollection<Order> Orders { get; set; }
        public ICollection<EventFeedback> EventFeedbacks { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}
