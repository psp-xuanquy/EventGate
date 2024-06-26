using EventGate.Data.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventGate.Data.Entity
{
    public class EventHistory : AbstractEntity
    {
        [Key]
        public string? EventHistoryID { get; set; } = Guid.NewGuid().ToString();
        public string? EventName { get; set; }
        public string? Location { get; set; }
        public string? Content { get; set; }
        public DateTime Date { get; set; }
        public byte[]? QRCode { get; set; }
        public int TicketQuantity { get; set; }
        public string? Status { get; set; }
        public DateTime ArchiveDate { get; set; }
        public DateTime PosterImage { get; set; }

        [ForeignKey("Event")]
        public string? EventID { get; set; }
        public Event? Event { get; set; }

        [ForeignKey("EventType")]
        public string? EventTypeID { get; set; }
        public EventType? EventType { get; set; }

        public virtual ICollection<UserEventHistory>? UserEventHistories { get; set; }
    }
}
