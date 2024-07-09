using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Models.DTOs.Request
{
    public class ChatDTO
    {
        public string? ChatRoomID { get; set; }
        public string? SenderID { get; set; }
        public string? Message { get; set; }
    }
}
