using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using EventGate.Data.Entities;

namespace EventGate.Data.Entity
{
    public class OrderDetail : AbstractEntity
    {
        [Key]
        public string OrderDetailID { get; set; } = Guid.NewGuid().ToString();
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        [ForeignKey("Order")]       
        public string? OrderID { get; set; }
        public Order? Order { get; set; }

        [ForeignKey("Ticket")]
        public string? TicketID { get; set; }
        public Ticket? Ticket { get; set; }
    }
}
