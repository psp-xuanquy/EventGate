﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Models.DTOs.Request
{
    public class EventTypeDTO
    {

        [Required(ErrorMessage = "EventTypeName is required")]
        public string EventTypeName { get; set; }
    }
}
