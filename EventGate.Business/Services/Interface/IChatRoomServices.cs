using EventGate.Business.Models.DTOs.Request.ChatRoom;
using EventGate.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Services.Interface
{
    public interface IChatRoomServices
    {
        Task<ServiceResult<int>> AddChatRoomAsync(ChatRoomAddDTO ChatRoomDTO);
        Task<ServiceResult<int>> DeleteAsync(string id);
        Task<ServiceResult<IEnumerable<ChatRoom>>> GetAllAsync();
        Task<ServiceResult<ChatRoom>> GetByIdAsync(string id);
        Task<ServiceResult<int>> UpdateAsync(string id, ChatUppdateDTO ChatRoom);
    }
}
