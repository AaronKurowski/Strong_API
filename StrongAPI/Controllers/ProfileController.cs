using Microsoft.AspNetCore.Mvc;
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
    }
}
