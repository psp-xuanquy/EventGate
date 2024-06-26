using EventGate.Data.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventGate.Data.Entity
{
    public class EventClub : AbstractEntity
    {
        [Key]
        public string EventClubID { get; set; } = Guid.NewGuid().ToString();

        [ForeignKey("Event")]
        public string? EventID { get; set; }
        public Event? Event { get; set; }

        [ForeignKey("Club")]
        public string? ClubID { get; set; }
        public Club? Club { get; set; }
    }
}
    