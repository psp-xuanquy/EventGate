using EventGate.Data.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventGate.Data.Entity
{
    public class Voucher : AbstractEntity
    {
        [Key]
        public string VoucherID { get; set; } = Guid.NewGuid().ToString();
        public string? Code { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public DateTime ValidDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; } = true;

        [ForeignKey("User")]
        public string? UserID { get; set; }
        public User? User { get; set; }

        [ForeignKey("Event")]
        public string? EventID { get; set; }
        public Event? Event { get; set; }
    }
}
