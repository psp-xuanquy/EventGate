using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using EventGate.Data.Entities;

namespace EventGate.Data.Entity
{
    public class UserEventHistory : AbstractEntity
    {
        [Key]
        public string? UserEventHistoryID { get; set; } = Guid.NewGuid().ToString();
        public DateTime? ArchiveDate { get; set; }
        public string? UserEventID { get; set; }
        public string? EventID { get; set; }
        public string? UserID { get; set; }

        //[ForeignKey("EventHistory")]
        //public string? EventHistoryID { get; set; }
        //public EventHistory? EventHistory { get; set; }

        //[ForeignKey("UserHistory")]
        //public string? UserHistoryID { get; set; }
        //public UserHistory? UserHistory { get; set; }
    }
}
