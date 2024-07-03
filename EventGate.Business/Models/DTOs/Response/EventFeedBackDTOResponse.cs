using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Models.DTOs.Response
{
    public class EventFeedBackDTOResponse
    {
        public string? Content { get; set; }
        public int Rating { get; set; }

        public string? UserID { get; set; }

        public string? EventID { get; set; }
        public DateTime SubmittedDate { get; set; }
    }
}
