using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using EventGate.Data.Entities;

namespace EventGate.Data.Entity
{
    public class Order : AbstractEntity
    {
        [Key]
        public string OrderID { get; set; } = Guid.NewGuid().ToString();
        public DateTime OrderDate { get; set; }
        public string? PaymentMethod { get; set; }
        public bool Status { get; set; }
        public decimal TotalPrice { get; set; }

        [ForeignKey("User")]
        public string? UserID { get; set; }
        public User? User { get; set; }

        public ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}
