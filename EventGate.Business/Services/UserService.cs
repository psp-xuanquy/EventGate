using AutoMapper;
using EventGate.Business.Mappers;
using EventGate.Business.Models.DTOs.Request;
using EventGate.Business.Models.DTOs.Request.User;
using EventGate.Business.Models.DTOs.Response.User;
using EventGate.Business.Services.Interface;
using EventGate.Data;
using EventGate.Data.Entity;
using EventGate.Data.Repositories;
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
        private readonly IUserHistoryRepository _userHistoryRepository;
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        private readonly AppDbContext _appDbContext;
        public UserService(IUserPropository userPropository,
            UserManager<User> userManager,
            IMapper mapper,
            AppDbContext appDbContext,
            IUserHistoryRepository userHistoryRepository)
        {
            _userRepository = userPropository;
            _userManager = userManager;
            _mapper = mapper;
            _userHistoryRepository = userHistoryRepository;
            _appDbContext = appDbContext;
        }


        //Get All User
        public async Task<IActionResult> GetAllAsync()
        {
            List<User> users = await _userRepository.GetAllAsync();
            return new OkObjectResult(_mapper.Map<List<UserDTOResponse>>(users));
        }

        //Get All User Deleted
        public async Task<IActionResult> GetAllDeletedAsync()
        {
            List<User> users = await _userRepository.GetAllDeletedAsync();
            return new OkObjectResult(_mapper.Map<List<UserDTOResponse>>(users));
        }


        //Find By Id
        public async Task<IActionResult> GetByIdAsync(string id)
        {
            User user = await _userRepository.GetByIdAsync(id);
            if (user == null)
            {
                return new BadRequestObjectResult($"UserId: '{id}' not found or has been deleted!");
            }
            return new OkObjectResult(_mapper.Map<UserDTOResponse>(user));
        }



        //Update User
        public async Task<IActionResult> UpdateAsync(UpdateUserDTORequest userDTO, string id)
        {
            User user = await _userRepository.GetByIdAsync(id);
            if (user == null)
            {
                return new BadRequestObjectResult($"UserId: '{id}' not found or has been deleted!");
            }

            List<User> users = await _userRepository.GetAllAsync();
            if (users.Any(user => user.Email == userDTO.Email && user.Id != id))
            {
                return new BadRequestObjectResult($"Gmail has already been used, please choose another one!");
            }
            if (users.Any(user => user.IdentityCard == userDTO.IdentityCard && user.Id != id))
            {
                return new BadRequestObjectResult($"IdentityCard has already been used ! *Note: IdentityCard must be unique!");
            }

            var entity = _mapper.Map(userDTO, user);

            int rs = await _userRepository.UpdateAsync(id, entity);
            if (rs == 0)
            {
                return new BadRequestObjectResult("Update User Fail!");
            }

            return new OkObjectResult("Update User Success!");
        }


        //Delete User
        public async Task<IActionResult> DeleteAsync(string id)
        {
            User user = await _userRepository.GetByIdAsync(id);
            if (user == null)
            {
                return new BadRequestObjectResult($"Userid: '{id}' Not found or been deleted!");
            }
            // Map User to UserHistoryDTORequest
            var userHistoryDTO = _mapper.Map<UserHistoryDTORequest>(user);

            // Map UserHistoryDTORequest to UserHistory entity
            var userHistory = _mapper.Map<UserHistory>(userHistoryDTO);

            // Add UserHistory entry
            await _userHistoryRepository.AddUserHistoryAsync(userHistory);

            Console.WriteLine($"UserID in DTO: {user.Id}");
            int rs = await _userRepository.DeleteAsync(user);
            if (rs == 0)
            {
                return new BadRequestObjectResult("Delete User fail!");
            }


           
            return new OkObjectResult("Delete User success!");

        }


        //Login 
        public async Task<ServiceResult<string>> Login(LoginDTO loginUser)
        {
            var result = new ServiceResult<string>();

            var user = await _userRepository.VerifyLoginAsync(loginUser.Username, loginUser.Password);
            if (user == null)
            {
                throw new Exception("Wrong User Name or Password");
            }

            if (user.EmailConfirmed == false)
            {
                throw new Exception("Email has not verified yet. Please verify by checking your mail");
            }

            // Generate JWT token
            var userRoles = await _userManager.GetRolesAsync(user);
            var token = await JwtGenerator.GenerateToken(user, userRoles.ToList(), _userRepository);

            result.Status = 1;
            result.ErrorMessage = "Login Successfully";
            result.IsSuccess = true;
            result.Data = token;


            return result;
        }


        //Register
        public async Task<ServiceResult<RegisterUserDTO>> RegisterByRole(RegisterUserDTO registerDTO, string role)
        {
            var result = new ServiceResult<RegisterUserDTO>();
            var userExists = await _userManager.FindByNameAsync(registerDTO.Username)
                              ?? await _userManager.FindByEmailAsync(registerDTO.Email);
            if (userExists != null)
            {
                throw new Exception("User already exists");
            }

            if (!registerDTO.Email.EndsWith("@fpt.edu.vn", StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception("Email must ends with @fpt.edu.vn");
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
                throw new Exception("Register Failed");
            }

            var roleResult = await _userManager.AddToRoleAsync(user, role);
            if (!roleResult.Succeeded)
            {
                throw new Exception("Cannot add role to User");
            }

            result.Status = 1;
            result.Data = registerDTO;
            result.IsSuccess = true;
            result.ErrorMessage = "Add Successfully";
            return result;

        }

        public async Task<ServiceResult<string>> ConfirmEmailUser(string userId)
        {
            var userExist = await _userRepository.GetByIdAsync(userId);
            if (userExist != null)
            {
                userExist.EmailConfirmed = true;
                userExist.isConfirmed = true;
                await _userRepository.UpdateAsync(userId, userExist);
            }

            var result = new ServiceResult<string>();
            result.Status = 1;
            result.IsSuccess = true;
            result.ErrorMessage = "Confirm Email Successfully";

            return result;
        }
    }
}
