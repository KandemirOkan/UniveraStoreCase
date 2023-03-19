using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniveraStoreCase.Entities.DTOs.ResponseDtos
{
    public class UserResponseDto
    {
        [Required]
        public string UserName { get; set; }
        public string Role { get; set; }
        public string Token { get; set; }
        public string Country { get; set; }
    }
}
