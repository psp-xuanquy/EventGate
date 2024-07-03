using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Models.DTOs.Request
{
    public class EventDTO
    {
        public string? EventName { get; set; }
        public string? Location { get; set; }
        public string? Content { get; set; }
        public string? LinkStream { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TicketQuantity { get; set; }
        public byte[]? PosterImage { get; set; }
        public byte[]? QRCode { get; set; }
        public string? EventTypeID { get; set; }
    }
}
