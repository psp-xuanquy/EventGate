using EventGate.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Data.Entities
{
    public class UserChatRoom : AbstractEntity
    {
        [Key]
        public string UserChatRoomID { get; set; }

        [ForeignKey("User")]
        public string UserID { get; set; }
        public User User { get; set; }

        [ForeignKey("ChatRoom")]
        public string ChatRoomID { get; set; }
        public ChatRoom ChatRoom { get; set; }
    }
}
