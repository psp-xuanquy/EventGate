using EventGate.Data.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventGate.Data.Entity
{
    public class Ticket : AbstractEntity
    {
        [Key]
        public string TicketID { get; set; } = Guid.NewGuid().ToString();
        public string? Gate { get; set; }
        public byte[]? QRCode { get; set; }
        public decimal Price { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsUsed { get; set; }

        [ForeignKey("Seat")]
        public string? SeatID { get; set; }
        public Seat? Seat { get; set; }

        [ForeignKey("Event")]
        public string? EventID { get; set; }
        public Event? Event { get; set; }

        public ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}
