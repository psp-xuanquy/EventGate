using AutoMapper;
using EventGate.Business.Mappers;
using EventGate.Business.Models.DTOs.Request.ChatRoom;
using EventGate.Business.Services.Interface;
using EventGate.Data.Entity;
using EventGate.Data.Repositories;
using EventGate.Data.Repositories.Interface;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Services
{
    public class ChatRoomServices : IChatRoomServices
    {
        private readonly IChatRoomRepository _chatRoomPropository;
        private readonly IMapper _Imapper;
        public ChatRoomServices(IChatRoomRepository ChatRoomPropository, IMapper mapper)
        {
            _chatRoomPropository = ChatRoomPropository;
            _Imapper = mapper;
        }

        public async Task<ServiceResult<int>> AddChatRoomAsync(ChatRoomAddDTO ChatRoomDTO)
        {
            var result = new ServiceResult<int>();

            try           
            {
                var chatRoom = _Imapper.Map<ChatRoom>(ChatRoomDTO);
                var addChatRoom = await _chatRoomPropository.AddARoom(chatRoom);
                result.IsSuccess = true;
                result.Data = addChatRoom;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }
        public async Task<ServiceResult<int>> UpdateAsync(string id, ChatUppdateDTO ChatRoom )
        {
            var result = new ServiceResult<int>();

            try
            {
                var chatRoom = _Imapper.Map<ChatRoom>(ChatRoom);
                var affectedRows = await _chatRoomPropository.UpdateRoom(id,  chatRoom);
                result.IsSuccess = true;
                result.Data = affectedRows;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        public async Task<ServiceResult<int>> DeleteAsync(string id)
        {
            var result = new ServiceResult<int>();

            try
            {
                var affectedRows = await _chatRoomPropository.DeleteRoom(id);
                result.IsSuccess = true;
                result.Data = affectedRows;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        public async Task<ServiceResult<IEnumerable<ChatRoom>>> GetAllAsync()
        {
            var result = new ServiceResult<IEnumerable<ChatRoom>>();

            try
            {
                var chatRooms = await _chatRoomPropository.GetAllRoom();
                result.IsSuccess = true;
                result.Data = chatRooms;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        public async Task<ServiceResult<ChatRoom>> GetByIdAsync(string id)
        {
            var result = new ServiceResult<ChatRoom>();

            try
            {
                var chatRoom = await _chatRoomPropository.GetByIdRoom(id);
                if (chatRoom == null)
                {
                    result.IsSuccess = false;
                    result.ErrorMessage = "Chat room not found";
                }
                else
                {
                    result.IsSuccess = true;
                    result.Data = chatRoom;
                }
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
