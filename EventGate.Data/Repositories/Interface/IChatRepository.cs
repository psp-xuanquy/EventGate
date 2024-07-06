using EventGate.Data.Entities;
using EventGate.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Data.Repositories.Interface
{
    public interface IChatRepository
    {
        Task<int> AddUsertoRoom(string UserID, string ChatRoomID);
         Task<int> Chat(string Message, string idUser, string idChatRoom);
        /*Task<int> MarkAsRead(string messageId, string userId);*/
    }
}
