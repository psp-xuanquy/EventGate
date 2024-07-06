using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Models.DTOs.Request.ChatRoom
{
    public class UserChatRoomAdd
    {
        [Required]
        public string UserID { get; set; }
        [Required]
        public string ChatRoomID { get; set; }
    }
}
