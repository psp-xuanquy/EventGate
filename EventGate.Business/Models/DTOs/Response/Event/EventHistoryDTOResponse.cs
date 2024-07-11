using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EventGate.Business.Models.DTOs.Response.Event
{
    public class EventHistoryDTOResponse
    {
        public string? EventName { get; set; }
        public string? Location { get; set; }
        public string? Content { get; set; }
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }
        public bool Status { get; set; }
        public string? PosterImage { get; set; }
        public int TicketQuantity { get; set; }
        public byte[]? QRCode { get; set; }
        public decimal? Price { get; set; }
        public string? ArchiveDate { get; set; }
        public string? EventID { get; set; }
        public EventTypeDTO EventType { get; set; }
    }

    public class EventTypeDTO
    {
        [JsonPropertyName("name")]
        public string? EventTypeName { get; set; }
    }
}
