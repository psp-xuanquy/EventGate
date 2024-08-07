﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Models.DTOs.Request.Order
{
    public class OrderDetailDTO
    {
        //public string OrderDetailID { get; set; }

        //[Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than zero")]
        //public int Quantity { get; set; }

        [Required(ErrorMessage = "TicketID is required")]
        public string TicketID { get; set; }
    }
}
