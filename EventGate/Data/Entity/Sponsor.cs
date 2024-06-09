using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventGate.Data.Entity
{
    public class Sponsor
    {
        [Key]
        public string SponsorID { get; set; } = Guid.NewGuid().ToString();
        public string SponsorName { get; set; }
        public string SponsorPhone { get; set; }
        public string SponsorEmail { get; set; }
        public string SponsorAddress { get; set; }
        public string SponsorWebsite { get; set; }

        [ForeignKey("ContactPerson")]
        public string ContactPersonID { get; set; }
        public User ContactPerson { get; set; }

        public ICollection<SponsorshipContribution> SponsorshipContributions { get; set; }
    }
}
