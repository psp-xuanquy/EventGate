using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EventGate.Business.Models.DTOs.Response.User
{

    public class UserEventDTOResponse
    {
        public EventDTO Event { get; set; }
        public UserDTO User { get; set; }
    }
}
