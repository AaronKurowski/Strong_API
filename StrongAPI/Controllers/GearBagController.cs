using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StrongAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrongAPI.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class GearBagController : ControllerBase
    {
        private Data.ApplicationDbContext _context;

        public GearBagController(Data.ApplicationDbContext context)
        {
            _context = context;
        }

        // get all items for a user
        [HttpGet("{userId}")]
        public IActionResult Get(string userId)
        {
            var items = _context.GearBags.Include(i => i.Gear).Include(i => i.User).Where(i => i.UserId == userId).ToList();

            return Ok(items);
        }

        // posts an item to the gearbag for a specific user
        [HttpPost("{userId}")]
        public IActionResult Post(string userId, [FromBody] GearBag value)
        {
            value.UserId = userId;
            _context.GearBags.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }

        // delete an item from the gearbag
        [HttpDelete("{userId}/{gearId}")]
        public IActionResult Delete(string userId, int gearId)
        {
            try
            {
                var item = _context.GearBags.Where(i => i.UserId == userId && i.GearId == gearId).SingleOrDefault();
                _context.GearBags.Remove(item);
                _context.SaveChanges();
                return StatusCode(204);
            }
            catch
            {
                return StatusCode(404);
            }
        }
    }
}
