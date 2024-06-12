using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventGate.Data.Entity
{
    public class EventHistory
    {
        [Key]
        public string EventHistoryID { get; set; } = Guid.NewGuid().ToString();
        public string EventName { get; set; }
        public string Location { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public string QRCode { get; set; }
        public int TicketQuantity { get; set; }
        public bool Status { get; set; }
        public string PosterImage { get; set; }
        public DateTime? ArchivedDate { get; set; }

        [ForeignKey("Event")]
        public string EventID { get; set; }
        public Event Event { get; set; }

        [ForeignKey("EventType")]
        public string EventTypeID { get; set; }
        public EventType EventType { get; set; }
    }
}
