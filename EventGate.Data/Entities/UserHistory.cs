using EventGate.Data.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventGate.Data.Entity
{
    public class UserHistory : AbstractEntity
    {
        [Key]
        public string? UserHistoryID { get; set; } = Guid.NewGuid().ToString();
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Mail { get; set; }
        public string? Avatar { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? IdentityCard { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? ArchivedDate { get; set; }

        public string? UserID { get; set; }

        public virtual ICollection<UserEventHistory>? UserEventHistories { get; set; }
    }
}
