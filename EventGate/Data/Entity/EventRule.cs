using System.ComponentModel.DataAnnotations;

namespace EventGate.Data.Entity
{
    public class EventRule
    {
        [Key]
        public string EventRuleID { get; set; } = Guid.NewGuid().ToString();
        public string RuleContent { get; set; }
        public string EventTypeID { get; set; }
        public EventType EventType { get; set; }
    }
}
