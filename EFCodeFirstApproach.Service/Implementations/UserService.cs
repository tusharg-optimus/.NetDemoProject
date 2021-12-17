using EFCodeFirstApproach.DataAccess.Entity;
using EFCodeFirstApproach.Repository.Interfaces;
using EFCodeFirstApproach.Service.Interfaces;
using EFCodeFirstApproach.Utils.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstApproach.Service.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<UserDTO> Add(UserDTO obj)
        {
            //Mapping from UserDTO to User
            var user = new User
            {
                Id = obj.Id,
                Name = obj.Name
            };
            var result = await _userRepository.Add(user);

            //Mapping from User to UserDTO
            var userDTO = new UserDTO
            {
                Id = result.Id,
                Name = result.Name,
            };
            return userDTO;     
        }

        public async Task<IEnumerable<UserDTO>> GetAll()
        {
            List<UserDTO> listUserDtos = new List<UserDTO>();
            var result = await _userRepository.GetAll();
            foreach (var item in result)
            {
                //Mapping from User to UserDTO
                var userDto = new UserDTO
                {
                    Id = item.Id,
                    Name = item.Name
                };
                listUserDtos.Add(userDto);
            }
            return listUserDtos;
        }
    }
}
