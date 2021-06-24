using Microsoft.AspNetCore.Mvc;
using StrongAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrongAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowController : ControllerBase
    {
        private Data.ApplicationDbContext _context;

        public ShowController(Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var shows = _context.ShowListings;
            return Ok(shows);
        }

        [HttpPost]
        public IActionResult Post([FromBody] ShowListing value)
        {
            _context.ShowListings.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }
    }
}
