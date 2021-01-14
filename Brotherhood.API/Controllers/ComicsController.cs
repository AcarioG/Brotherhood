using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Brotherhood.Domain.Models;

namespace Brotherhood.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComicsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ComicsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Comics
        [HttpGet]
        //public IEnumerable<Comics> Get()
        //{
        //    return Get();
        //}

        // GET: api/Comics/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Comics>> GetComics(int id)
        {
            var comics = await _context.Comics.FindAsync(id);

            if (comics == null)
            {
                return NotFound();
            }

            return comics;
        }

        // PUT: api/Comics/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComics(int id, Comics comics)
        {
            if (id != comics.Id)
            {
                return BadRequest();
            }

            _context.Entry(comics).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComicsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Comics
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Comics>> PostComics(Comics comics)
        {
            _context.Comics.Add(comics);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetComics", new { id = comics.Id }, comics);
        }

        // DELETE: api/Comics/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComics(int id)
        {
            var comics = await _context.Comics.FindAsync(id);
            if (comics == null)
            {
                return NotFound();
            }

            _context.Comics.Remove(comics);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ComicsExists(int id)
        {
            return _context.Comics.Any(e => e.Id == id);
        }
    }
}
