using EventGate.Data.DTOs.Request;
using EventGate.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Mappers
{
    public class UserMapper : IMapper<User, UserDTORequest>
    {
        public UserDTORequest Map(User user)
        {
            return new UserDTORequest
            {
                UserName = user.UserName,
                Avatar = user.Avatar,
                Address = user.Address,
                IdentityCard = user.IdentityCard,
                DateOfBirth = user.DateOfBirth
            };
        }

        public User Map(UserDTORequest userDto)
        {
            return new User
            {
                UserName = userDto.UserName,
                Avatar = userDto.Avatar,
                Address = userDto.Address,
                IdentityCard = userDto.IdentityCard,
                DateOfBirth = userDto.DateOfBirth
            };
        }
    }
}
