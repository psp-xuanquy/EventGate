using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Models.DTOs.Request.ChatRoom
{
    public class ChatRoomAddDTO
    {
        public string? ChatRoomID = Guid.NewGuid().ToString("N");
        [Required]
        public string? RoomName { get; set; }
        [Required]
        public string? Description { get; set; }
    }
}
