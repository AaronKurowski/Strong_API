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

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var show = _context.ShowListings;
            return Ok(show);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            foreach (var show in _context.ShowListings.Where(s => s.ShowListingId == id).ToArray()) _context.ShowListings.Remove(show);
            _context.SaveChanges();
            return StatusCode(204);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]ShowListing value)
        {
            var show = _context.ShowListings.Where(s => s.ShowListingId == id).SingleOrDefault();
            show.Name = value.Name;
            show.Description = value.Description;
            show.Bands = value.Bands;
            show.EntryFee = value.EntryFee;
            show.ImageURL = value.ImageURL;
            show.Date = value.Date;

            _context.SaveChanges();

            return StatusCode(200, show);

        }
    }
}

//public string Name { get; set; }
//public string Description { get; set; }
//public string Bands { get; set; }
//public int EntryFee { get; set; }
//public string ImageURL { get; set; }
//public DateTime Date { get; set; }
//    }