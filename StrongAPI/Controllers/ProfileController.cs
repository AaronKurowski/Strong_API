using Microsoft.AspNetCore.Mvc;
using StrongAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace StrongAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private Data.ApplicationDbContext _context;

        public ProfileController(Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var profiles = _context.Users;
            return Ok(profiles);
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var profile = _context.Users.Where(p => p.Id == id);
            return Ok(profile);
        }

        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody]User value)
        {
            var user = _context.Users.Where(u => u.Id == id).SingleOrDefault();
            user.FirstName = value.FirstName;
            user.LastName = value.LastName;
            user.Instrument = value.Instrument;
            user.Genre = value.Genre;
            user.Band = value.Band;
            user.Email = value.Email;

            _context.SaveChanges();

            return Ok(user);
        }
    }
}
