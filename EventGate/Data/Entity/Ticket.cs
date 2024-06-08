﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventGate.Data.Entity
{
    public class Ticket
    {
        [Key]
        public string TicketID { get; set; } = Guid.NewGuid().ToString();
        public string Seat { get; set; }
        public string Gate { get; set; }
        public decimal Price { get; set; }
        public string QRCode { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsUsed { get; set; }

        [ForeignKey("Event")]
        public string EventID { get; set; }
        public Event Event { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
