using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EventGate.Data.Entity
{
    public class OrderDetail
    {
        [Key]
        public string OrderDetailID { get; set; } = Guid.NewGuid().ToString();
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }

        [ForeignKey("Order")]
        public string OrderID { get; set; }
        public Order Order { get; set; }

        [ForeignKey("Ticket")]
        public string TicketID { get; set; }
        public Ticket Ticket { get; set; }
    }
}
