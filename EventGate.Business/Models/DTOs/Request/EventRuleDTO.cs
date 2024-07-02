using EventGate.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Models.DTOs.Request
{
    public class EventRuleDTO
    {
        [Required(ErrorMessage = "RuleDescription is required")]
        public string? RuleDescription { get; set; }

        [Required(ErrorMessage = "EventTypeID is required")]
        public string? EventTypeID { get; set; }
    }
}
