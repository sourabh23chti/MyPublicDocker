﻿namespace IdentityService.DTO
{
    public class LoginResponseDto
    {
        public UserDto User { get; set; }

        public string token { get; set; }
    }
}
