using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventGate.Data.Entity
{
    public class EventFinancials
    {
        [Key]
        public string EventFinID { get; set; } = Guid.NewGuid().ToString();
        public decimal TotalRevenue { get; set; }
        public decimal ServiceFeePercent { get; set; }
        public decimal ServiceFeeAmount { get; set; }
        public decimal NetRevenue { get; set; }
        public string Status { get; set; }

        [ForeignKey("Event")]
        public string EventID { get; set; }
        public Event Event { get; set; }
    }
}
