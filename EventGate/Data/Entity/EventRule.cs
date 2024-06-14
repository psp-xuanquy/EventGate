using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventGate.Data.Entity
{
    public class EventRule
    {
        [Key]
        public string RuleID { get; set; } = Guid.NewGuid().ToString();
        public string? RuleDescription { get; set; }

        [ForeignKey("EventType")]
        public string? EventTypeID { get; set; }
        public EventType? EventType { get; set; }
    }
}
