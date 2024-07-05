using EventGate.Business.Models.DTOs.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Models.DTOs.Response.Event
{
    public class EventDTOResponse
    {
        public string? EventId { get; set; }
        public string? EventName { get; set; }
        public string? Location { get; set; }
        public string? Content { get; set; }
        public string? LinkStream { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TicketQuantity { get; set; }
        public string? PosterImage { get; set; }
        public byte[]? QRCode { get; set; }
        public string? EventTypeName { get; set; }
        public string? ClubName { get; set; }
        public string? LogoClub { get; set; }
        public string? PhonePresident { get; set; }
        public string? GmailContact {  get; set; }
        public decimal Price { get; set; }
    }
}
