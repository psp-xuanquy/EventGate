using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EventGate.Data.Entity
{
    public class Blog
    {
        [Key]
        public string BlogID { get; set; } = Guid.NewGuid().ToString();
        public string? Image { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime UploadedDate { get; set; }

        [ForeignKey("Event")]
        public string? EventID { get; set; }
        public Event? Event { get; set; }

        [ForeignKey("Author")]
        public string? AuthorID { get; set; }
        public User? Author { get; set; }
    }
}
