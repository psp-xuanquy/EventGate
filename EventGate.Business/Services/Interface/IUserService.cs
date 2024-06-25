using EventGate.Business.Models.DTOs.Request;
using EventGate.Data.DTOs.Request;
using EventGate.Data.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Services.Interface
{
    public interface IUserService
    {
        Task<ServiceResult<int>> AddAsync(UserDTORequest user);
        Task<ServiceResult<int>> UpdateAsync(UserDTORequest user);
        Task<ServiceResult<int>> DeleteAsync(Guid id);
        Task<ServiceResult<User>> GetByIdAsync(Guid id);
        Task<ServiceResult<IEnumerable<User>>> GetAllAsync();
        Task<ServiceResult<string>> Login(LoginDTO loginUser);
        Task<ServiceResult<int>> RegisterByRole(RegisterUserDTO registerMentorDTO, string member);
    }
}
