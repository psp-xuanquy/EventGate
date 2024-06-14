using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EventGate.Data.Entity
{
    public class UserEventHistory
    {
        [Key]
        public string? UserEventHistoryID { get; set; }
        public DateTime ArchiveDate { get; set; }

        [ForeignKey("EventHistory")]
        public string? EventHistoryID { get; set; }
        public EventHistory? EventHistory { get; set; }

        [ForeignKey("UserHistory")]
        public string? UserHistoryID { get; set; }
        public UserHistory? UserHistory { get; set; }
    }
}
