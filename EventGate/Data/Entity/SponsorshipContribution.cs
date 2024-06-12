using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EventGate.Data.Entity
{
    public class SponsorshipContribution
    {
        [Key]
        public string ContributionID { get; set; } = Guid.NewGuid().ToString();
        public decimal AmountSponsored { get; set; }
        public DateTime ContributionDate { get; set; }

        [ForeignKey("Sponsor")]
        public string SponsorID { get; set; }
        public Sponsor Sponsor { get; set; }

        [ForeignKey("Event")]
        public string EventID { get; set; }
        public Event Event { get; set; }

        [ForeignKey("SponsorshipType")]
        public string TypeID { get; set; }
        public SponsorshipType SponsorshipType { get; set; }
    }
}
