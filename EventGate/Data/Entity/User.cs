using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventGate.Data.Entity
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }

        public ICollection<Order> Orders { get; set; }
        public ICollection<EventFeedback> EventFeedbacks { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}
