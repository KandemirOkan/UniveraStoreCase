using AutoMapper;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using UniveraStoreCase.DataAccess.Repositories.IRepositories;
using UniveraStoreCase.Entities.DTOs.RequestDtos;
using UniveraStoreCase.Entities.DTOs.ResponseDtos;
using UniveraStoreCase.Entities.Entities;


namespace UniveraStoreCase.Business.Services.UserServices
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository,IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public void CreateUser(UserRequestDto userRequestDto)
        {
            var user = new User { UserName = userRequestDto.UserName, Role = userRequestDto.Role, Country = userRequestDto.Country };
            if (userRequestDto.ConfirmPassword == userRequestDto.Password)
            {
                using (HMACSHA512 hmac = new HMACSHA512())
                {
                    user.PasswordSalt = hmac.Key;
                    user.PasswordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(userRequestDto.Password));
                }
            }
            _userRepository.Add(user);
            _userRepository.Save();
        }
        public UserResponseDto LoginUser(UserLoginRequestDto userLoginRequestDto)
        {
            var user = _userRepository.GetEntity(x => x.UserName == userLoginRequestDto.UserName).FirstOrDefault();
            if (user == null)
            {
                return null;
            }
            var match = CheckPassword(userLoginRequestDto.Password, user);
            if (!match)
            {
                return null;
            }
            return _mapper.Map<UserResponseDto>(user);
        }
        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<List<UserResponseDto>> GetAllUsers()
        {
            var user = await _userRepository.GetAllAsync();
            var userResponse = _mapper.Map<List<UserResponseDto>>(user);
            return userResponse;
        }
        public Task<UserResponseDto> GetUserById(int id)
        {
            throw new NotImplementedException();
        }
        public void UpdateUser(UserResponseDto userResponseDto)
        {
            throw new NotImplementedException();
        }
        private bool CheckPassword(string password, User user)
        {
            bool result;
            using (HMACSHA512 hmac = new HMACSHA512(user.PasswordSalt))
            {
                var compute = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                result = compute.SequenceEqual(user.PasswordHash);
            }
            return result;
        }
    }
}
