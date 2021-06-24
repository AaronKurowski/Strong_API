using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace StrongAPI.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Instrument { get; set; }
        public string Genre { get; set; }
        public string Band { get; set; }
    }
}
