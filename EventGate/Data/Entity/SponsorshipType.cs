using System.ComponentModel.DataAnnotations;

namespace EventGate.Data.Entity
{
    public class SponsorshipType
    {
        [Key]
        public string TypeID { get; set; } = Guid.NewGuid().ToString();
        public string TypeName { get; set; }
        public string Description { get; set; }

        public ICollection<SponsorshipContribution> SponsorshipContributions { get; set; }
    }
}
