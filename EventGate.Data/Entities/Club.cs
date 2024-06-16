using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EventGate.Data.Entity
{
    public class Club
    {
        [Key]
        public string ClubID { get; set; } = Guid.NewGuid().ToString();
        public string? Name { get; set; }
        public int? MemberQuantity { get; set; }
        public string? LogoClub { get; set; }
        public string? Description { get; set; }

        [ForeignKey("President")]
        public string? PresidentID { get; set; }
        public User? President { get; set; }

        public ICollection<EventClub>? EventClubs { get; set; }
    }
}
