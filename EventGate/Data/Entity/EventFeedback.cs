using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EventGate.Data.Entity
{
    public class EventFeedback
    {
        [Key]
        public string FeedbackID { get; set; } = Guid.NewGuid().ToString();
        public string? Content { get; set; }
        public int Rating { get; set; }
        public DateTime SubmittedDate { get; set; }

        [ForeignKey("User")]
        public string? UserID { get; set; }
        public User? User { get; set; }

        [ForeignKey("Event")]
        public string? EventID { get; set; }
        public Event? Event { get; set; }
    }
}
