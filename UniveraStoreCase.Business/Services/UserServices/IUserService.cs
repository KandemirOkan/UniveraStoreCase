using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniveraStoreCase.Entities.DTOs.RequestDtos;
using UniveraStoreCase.Entities.DTOs.ResponseDtos;

namespace UniveraStoreCase.Business.Services.UserServices
{
    public interface IUserService
    {
        Task<List<UserResponseDto>> GetAllUsers();
        Task<UserResponseDto> GetUserById(int id);
        public void CreateUser(UserRequestDto userRequestDto);
        public UserResponseDto LoginUser(UserLoginRequestDto userLoginRequestDto);
        public void UpdateUser(UserResponseDto userResponseDto);
        public void DeleteUser(int id);
    }
}
