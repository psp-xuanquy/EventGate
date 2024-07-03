using EventGate.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Models.DTOs.Request
{
    public class EventFeedBackDTO
    {
        public string? Content { get; set; }
        [Range(0, 5, ErrorMessage = "Rating must be between 0 and 5.")]
        public int Rating { get; set; }

        public string? UserID { get; set; }
  
        public string? EventID { get; set; }

    }
}
