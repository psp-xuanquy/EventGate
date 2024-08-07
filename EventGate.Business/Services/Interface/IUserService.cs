﻿using EventGate.Business.Models.DTOs.Request;
using EventGate.Business.Models.DTOs.Request.User;
using EventGate.Business.Models.DTOs.Response.User;
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


        Task<IActionResult> GetAllAsync();
        
        Task<IActionResult> GetByIdAsync(string id);
        Task<IActionResult> UpdateAsync(UpdateUserDTORequest user, string id);
        // Task<ServiceResult<User>> GetByNameAndEmail(string UserName, string UserEmail);
        
        Task<IActionResult> DeleteAsync(string id);
        Task<ServiceResult<UserDTOResponse>> Login(LoginDTO loginUser);
        Task<ServiceResult<RegisterUserDTO>> RegisterByRole(RegisterUserDTO registerMentorDTO, string member);
        Task<ServiceResult<string>> ConfirmEmailUser(string userId);
        Task<ServiceResult<UserDTOResponse>> LoginbyGmail(string email);
        Task<ServiceResult<RegisterUserWithAvatarDTO>> RegisterByRole2(RegisterUserWithAvatarDTO registerDTO, string role, string avatar);
    }
}
