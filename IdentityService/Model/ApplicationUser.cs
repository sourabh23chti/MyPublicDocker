﻿using Microsoft.AspNetCore.Identity;

namespace IdentityService.Model
{
    public class ApplicationUser:IdentityUser
    {
        public string UserName { get; set; }
    }
}
