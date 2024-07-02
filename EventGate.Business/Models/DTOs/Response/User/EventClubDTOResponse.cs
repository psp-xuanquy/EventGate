using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EventGate.Business.Models.DTOs.Response.User
{

    public class UserDTO
    {
        [JsonPropertyName("name")]
        public string UserName { get; set; }
    }

    public class EventDTO
    {
        [JsonPropertyName("name")]
        public string EventName { get; set; }
        public string Content { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public string Location { get; set; }
    }

    public class ClubDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public UserDTO President { get; set; }
    }



    public class EventClubDTOResponse
    {
        public EventDTO Event { get; set; }
        public ClubDTO Club { get; set; }
    }
}
