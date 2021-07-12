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
    public class GearController : ControllerBase
    {
        private Data.ApplicationDbContext _context;

        public GearController(Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var gear = _context.Gear;
            return Ok(gear);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Gear value)
        {
            _context.Gear.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }


        // gets all pieces of gear from a specific user
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var gear = _context.Gear.Where(g => g.UserId == id);
            return Ok(gear);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Gear value)
        {
            var gear = _context.Gear.Where(g => g.GearId == id).SingleOrDefault();
            gear.BuyerId = value.BuyerId;

            _context.SaveChanges();

            return Ok(gear);
        }
    }
}
