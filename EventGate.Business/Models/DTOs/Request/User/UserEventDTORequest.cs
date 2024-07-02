using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Models.DTOs.Request.User
{
    public class UserEventDTORequest
    {
        public string UserId { get; set; }
        public string EventId { get; set; }
    }
}
