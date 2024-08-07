﻿using EventGate.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventGate.Data.Entity
{
    public class Event : AbstractEntity
    {
        [Key]
        public string? EventID { get; set; } = Guid.NewGuid().ToString();
        public string? EventName { get; set; }
        public string? Location { get; set; }
        public string? Content { get; set; }
        public string? LinkStream { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Status { get; set; }
        public int TicketQuantity { get; set; }
        public string? PosterImage { get; set; }
        public byte[]? QRCode { get; set; }
        public decimal? Price { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey("EventType")]
        public string? EventTypeID { get; set; }
        public EventType? EventType { get; set; }

        public PaymentsInfo? PaymentsInfo { get; set; }

        public ICollection<Ticket>? Tickets { get; set; }
        public ICollection<Voucher>? Vouchers { get; set; }
        public ICollection<Blog>? Blogs { get; set; }
        public ICollection<EventFeedback>? EventFeedbacks { get; set; }
        public ICollection<EventClub>? EventClubs { get; set; }
        public ICollection<UserEvent>? UserEvents { get; set; }
        //public ICollection<EventHistory>? EventHistories { get; set; }
    }
}
