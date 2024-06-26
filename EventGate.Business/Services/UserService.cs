using EventGate.Business.Mappers;
using EventGate.Business.Models.DTOs.Request;
using EventGate.Business.Services.Interface;
using EventGate.Data.DTOs.Request;
using EventGate.Data.Entity;
using EventGate.Data.Repositories.Interface;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Services
{
    public class UserService : IUserService
    {
        private readonly IUserPropository _userRepository;
        private readonly IMapper<User, UserDTORequest> _userMapper;
        private readonly UserManager<User> _userManager;

        public UserService(IUserPropository userPropository, UserManager<User> userManager)
        {
            _userRepository = userPropository;
            _userManager = userManager;
        }

        public async Task<ServiceResult<int>> AddAsync(UserDTORequest userDTO)
        {
            var result = new ServiceResult<int>();

            try
            {
                var user = _userMapper.Map(userDTO);
                var affectedRows = await _userRepository.AddAsync(user);
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

        public async Task<ServiceResult<int>> DeleteAsync(Guid id)
        {
            var result = new ServiceResult<int>();

            try
            {
                var affectedRows = await _userRepository.DeleteAsync(id);
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

        public async Task<ServiceResult<IEnumerable<User>>> GetAllAsync()
        {
            var result = new ServiceResult<IEnumerable<User>>();

            try
            {
                var users = await _userRepository.GetAllAsync();
                result.IsSuccess = true;
                result.Data = users;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        public async Task<ServiceResult<User>> GetByIdAsync(Guid id)
        {
            var result = new ServiceResult<User>();

            try
            {
                var user = await _userRepository.GetByIdAsync(id);
                if (user == null)
                {
                    result.IsSuccess = false;
                    result.ErrorMessage = "User not found";
                }
                else
                {
                    result.IsSuccess = true;
                    result.Data = user;
                }
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        public async Task<ServiceResult<string>> Login(LoginDTO loginUser)
        {
            var result = new ServiceResult<string>();

            try
            {
                var user = await _userRepository.VerifyLoginAsync(loginUser.Username, loginUser.Password);
                if (user == null)
                {
                    result.IsSuccess = false;
                    result.ErrorMessage = "User does not exist";
                    return result;
                }

                // Generate JWT token
                var userRoles = await _userManager.GetRolesAsync(user);
                var token = JwtGenerator.GenerateToken(user, userRoles.ToList());
                result.IsSuccess = true;
                result.Data = token;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        public async Task<ServiceResult<int>> UpdateAsync(UserDTORequest userDTO)
        {
            var result = new ServiceResult<int>();

            try
            {
                var user = _userMapper.Map(userDTO);
                var affectedRows = await _userRepository.UpdateAsync(user);
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

        public async Task<ServiceResult<int>> RegisterByRole(RegisterUserDTO registerDTO, string role)
        {
            var result = new ServiceResult<int>();
            var userExists = await _userManager.FindByNameAsync(registerDTO.Username)
                              ?? await _userManager.FindByEmailAsync(registerDTO.Email);
            if (userExists != null)
            {
                result.IsSuccess = false;
                result.ErrorMessage = "User already exist";
                return result;
            }

            var user = new User
            {
                UserName = registerDTO.Username,
                Email = registerDTO.Email,
                isConfirmed = false,
                EmailConfirmed = false,
            };

            var newUser = await _userManager.CreateAsync(user, registerDTO.Password);

            if (!newUser.Succeeded)
            {
                result.IsSuccess = false;
                result.ErrorMessage = "Add Failed";
                return result;
            }

            var roleResult = await _userManager.AddToRoleAsync(user, role);
            if (!roleResult.Succeeded)
            {
                result.IsSuccess = false;
                result.ErrorMessage = "Cannot add role to User";
                return result;
            }

            result.IsSuccess = true;
            result.ErrorMessage = "Add Successfully";
            return result;


        }
    }
}
