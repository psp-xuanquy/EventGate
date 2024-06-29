using EventGate.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Data.Entities
{
    public class ChatReceiver : AbstractEntity
    {
        [Key]
        public string ChatReceiverID { get; set; } = Guid.NewGuid().ToString();

        [ForeignKey("Chat")]
        public string ChatID { get; set; }
        public Chat Chat { get; set; }

        [ForeignKey("Receiver")]
        public string ReceiverID { get; set; }
        public User Receiver { get; set; }
    }

}
