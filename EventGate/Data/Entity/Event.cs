using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Sockets;

namespace EventGate.Data.Entity
{
    public class Event
    {
        [Key]
        public string EventID { get; set; } = Guid.NewGuid().ToString();
        public string EventName { get; set; }
        public string Location { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public string QRCode { get; set; }
        public int TicketQuantity { get; set; }
        public string PosterImage { get; set; }
        public bool IsDeleted { get; set; } = false;

        [ForeignKey("EventType")]
        public string EventTypeID { get; set; }
        public EventType EventType { get; set; }

        public PaymentsInfo PaymentsInfo { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
        public ICollection<EventFeedback> EventFeedbacks { get; set; }
        public ICollection<EventClub> EventClubs { get; set; }
        public ICollection<SponsorshipContribution> SponsorshipContributions { get; set; }
        public ICollection<UserEvent> UserEvents { get; set; }
        public ICollection<EventHistory> EventHistories { get; set; }
    }
}
