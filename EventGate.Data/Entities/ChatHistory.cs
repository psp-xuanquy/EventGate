using EventGate.Data.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventGate.Data.Entity
{
    public class ChatHistory : AbstractEntity
    {
        [Key]
        public string ChatHistoryID { get; set; } = Guid.NewGuid().ToString();
        public string? Message { get; set; }
        public DateTime SentDate { get; set; }
        public DateTime? ArchivedDate { get; set; }

        public string? ChatID { get; set; }

        public string? SenderID { get; set; }

        [ForeignKey("ChatRoom")]
        public string? ChatRoomID { get; set; }
        public ChatRoom? ChatRoom { get; set; }
    }
}
