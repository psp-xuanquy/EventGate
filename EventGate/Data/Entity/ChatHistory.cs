using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventGate.Data.Entity
{
    public class ChatHistory
    {
        [Key]
        public string ChatHistoryID { get; set; } = Guid.NewGuid().ToString();
        public string Message { get; set; }
        public DateTime SentDate { get; set; }
        public DateTime? ArchivedDate { get; set; }

        [ForeignKey("Chat")]
        public string ChatID { get; set; }
        public Chat Chat { get; set; }

        [ForeignKey("Sender")]
        public string SenderID { get; set; }
        public User Sender { get; set; }

        [ForeignKey("Receiver")]
        public string ReceiverID { get; set; }
        public User Receiver { get; set; }
    }
}
