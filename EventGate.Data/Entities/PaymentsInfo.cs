using EventGate.Data.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventGate.Data.Entity
{
    public class PaymentsInfo : AbstractEntity
    {
        [Key]
        public string? PaymentsInfoID { get; set; } = Guid.NewGuid().ToString();
        public string? AccountHolderName { get; set; }
        public string? AccountNumber { get; set; }
        public string? BankName { get; set; }
        public string? BankBranch { get; set; }
        public decimal TotalPayments { get; set; }
        public DateTime ValidDate { get; set; }

        [ForeignKey("Event")]
        public string? EventID { get; set; }
        public Event? Event { get; set; }
    }
}
