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
    public class SongController : ControllerBase
    {
        private Data.ApplicationDbContext _context;

        public SongController(Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var songs = _context.Songs;
            return Ok(songs);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Song value)
        {
            _context.Songs.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var song = _context.Songs.Where(s => s.SongId == id).SingleOrDefault();
            return Ok(song);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            foreach (var song in _context.Songs.Where(s => s.SongId == id).ToArray()) _context.Songs.Remove(song);
            _context.SaveChanges();

            return StatusCode(204);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Song value)
        {
            var song = _context.Songs.Where(s => s.SongId == id).SingleOrDefault();
            song.Title = value.Title;
            song.Artist = value.Artist;
            song.Album = value.Album;
            song.AudioFile = value.AudioFile;
            song.ImageURL = value.ImageURL;
            song.ReleaseDate = value.ReleaseDate;

            _context.SaveChanges();

            return Ok(song);
        }
    }
}
