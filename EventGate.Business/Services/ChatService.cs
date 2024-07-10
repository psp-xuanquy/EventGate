using AutoMapper;
using EventGate.Business.Models.DTOs.Request.ChatRoom;
using EventGate.Business.Services.Interface;
using EventGate.Data.Entity;
using EventGate.Data.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Services
{
    public class ChatService : IChatService
    {
        private readonly IChatRepository _chatRepository;
      
        public ChatService(IChatRepository chatRepository)
        {
            _chatRepository  = chatRepository;
        }

        public async Task<ServiceResult<IEnumerable<Chat>>> GetAllAsync(string idchatroom)
        {
            var result = new ServiceResult<IEnumerable<Chat>>();

            try
            {
                var chat = await _chatRepository.GetAllChat(idchatroom);
                result.IsSuccess = true;
                result.Data = chat;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }
    }
}
