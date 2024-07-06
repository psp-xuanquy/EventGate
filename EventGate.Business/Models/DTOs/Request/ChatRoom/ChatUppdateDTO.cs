using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Models.DTOs.Request.ChatRoom
{
    public class ChatUppdateDTO
    {
        public string? RoomName { get; set; }
        public string? Description { get; set; }
    }
}
