using System.ComponentModel.DataAnnotations;

namespace EventGate.Data.Entity
{
    public class EventType
    {
        [Key]
        public string EventTypeID { get; set; } = Guid.NewGuid().ToString();
        public string? EventTypeName { get; set; }

        public ICollection<Event>? Events { get; set; }
        public ICollection<EventRule>? EventRules { get; set; }
        public ICollection<EventHistory>? EventHistories { get; set; }
    }
}
