using EventGate.Data.Entities;

namespace EventGate.Data.Entity
{
    public class ChatRoom : AbstractEntity
    {
        public string? ChatRoomID { get; set; } = Guid.NewGuid().ToString();
        public string? RoomName { get; set; }
        public string? Description { get; set; }

        public ICollection<Chat>? Chats { get; set; }
        public ICollection<UserChatRoom>? UserChatRooms { get; set; }
    }
}
