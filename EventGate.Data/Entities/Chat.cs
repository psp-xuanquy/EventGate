using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using EventGate.Data.Entities;

namespace EventGate.Data.Entity
{
    public class Chat : AbstractEntity
    {
        [Key]
        public string ChatID { get; set; } = Guid.NewGuid().ToString();
        public string? Message { get; set; }
        public DateTime SentDate { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey("ChatRoom")]
        public string? ChatRoomID { get; set; }
        public ChatRoom? ChatRoom { get; set; }

        [ForeignKey("Sender")]
        public string? SenderID { get; set; }
        public User? Sender { get; set; }

        //[ForeignKey("Receiver")]
        //public string? ReceiverID { get; set; }
        //public User? Receiver { get; set; }

        public ICollection<ChatHistory>? ChatHistories { get; set; }
        public ICollection<ChatReceiver>? ChatReceivers { get; set; }
    }
}
