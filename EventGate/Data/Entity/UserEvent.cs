using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventGate.Data.Entity
{
    public class UserEvent
    {
        [Key]
        public string UserEventID { get; set; } = Guid.NewGuid().ToString();

        [ForeignKey("User")]
        public string? UserID { get; set; }
        public User? User { get; set; }

        [ForeignKey("Event")]
        public string? EventID { get; set; }
        public Event? Event { get; set; }
    }
}
