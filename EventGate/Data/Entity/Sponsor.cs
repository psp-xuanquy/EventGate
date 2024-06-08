using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventGate.Data.Entity
{
    public class Sponsor
    {
        [Key]
        public string SponsorID { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Website { get; set; }

        [ForeignKey("ContactPerson")]
        public string ContactPersonID { get; set; }
        public User ContactPerson { get; set; }

        public ICollection<SponsorshipContribution> SponsorshipContributions { get; set; }
    }
}
