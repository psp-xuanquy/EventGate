using EventGate.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Data.Repositories.Interface
{
    public interface IChatRoomRepository
    {
        Task<int> AddARoom(ChatRoom room);
        Task<int> DeleteRoom(string id);
        Task<IEnumerable<ChatRoom>> GetAllRoom();
        Task<ChatRoom> GetByIdRoom(string id);
        Task<int> UpdateRoom(string id, ChatRoom chatRoom);
    }
}
