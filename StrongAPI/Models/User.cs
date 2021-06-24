﻿using Microsoft.AspNetCore.Identity;

namespace StrongAPI.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Instrument { get; set; }
    }
}
