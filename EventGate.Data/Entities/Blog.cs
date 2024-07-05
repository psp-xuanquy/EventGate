using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using EventGate.Data.Entities;

namespace EventGate.Data.Entity
{ 
    public class Blog : AbstractEntity
    {
        [Key]
        public string BlogID { get; set; } = Guid.NewGuid().ToString();
        public string? Image { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime UploadedDate { get; set; } = DateTime.Now;

        [ForeignKey("Event")]
        public string? EventID { get; set; }
        public Event? Event { get; set; }

        [ForeignKey("Author")]
        public string? AuthorID { get; set; }
        public User? Author { get; set; }
    }
}
