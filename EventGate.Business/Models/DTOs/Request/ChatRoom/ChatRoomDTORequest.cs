using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Models.DTOs.Request.ChatRoom
{
    public class ChatRoomDTORequest
    {
        public string? ChatRoomID { get; set; }
        public string? RoomName { get; set; }
        public string? Description { get; set; }
        public DateTime? DeletedTime { get; set; }
    }
}
