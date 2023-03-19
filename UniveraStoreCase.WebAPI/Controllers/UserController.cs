using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using UniveraStoreCase.Business.Services.UserServices;
using UniveraStoreCase.Entities.DTOs.RequestDtos;
using UniveraStoreCase.Entities.DTOs.ResponseDtos;

namespace UniveraStoreCase.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly AppSettings applicationSettings;

        public UserController(IUserService userService, IOptions<AppSettings> _applicationSettings)
        {
            _userService = userService;
            applicationSettings = _applicationSettings.Value;
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllUsersAsync()
        {
            var users = await _userService.GetAllUsers();
            return Ok(users);
        }
        [HttpPost("[action]")]
        public IActionResult Register([FromBody] UserRequestDto newUser)
        {
            _userService.CreateUser(newUser);
            return Ok();
        }
        [HttpPost("[action]")]
        public IActionResult Login([FromBody] UserLoginRequestDto loginUser)
        {
            var user = _userService.LoginUser(loginUser);

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(applicationSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.UserName), new Claim(ClaimTypes.Role, user.Role) }),
                Expires = DateTime.UtcNow.AddDays(10),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var encrypterToken = tokenHandler.WriteToken(token);
            return Ok(new { token = encrypterToken, username = user.UserName, country = user.Country });
        }
    }
}
