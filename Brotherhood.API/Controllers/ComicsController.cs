using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Brotherhood.Services.Interfaces;
using Brotherhood.Domain.DTOs;
using Brotherhood.Services;
using Microsoft.AspNetCore.Cors;

namespace Brotherhood.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class ComicsController : ControllerBase
    {
        private readonly IComicServices _comicServices;

        public ComicsController(IComicServices comicServices)
        {
            _comicServices = comicServices;
        }

        //GET: api/Comics
        [HttpGet]
        public async Task<IEnumerable<ComicsDTO>> GetAsync()
            {
            var comics = await _comicServices.GetAllComicsAsync();

            if (comics == null)
            {
                return (IEnumerable<ComicsDTO>)NotFound();
            }

            return comics;
        }

        // GET: api/Comics/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ComicsDTO>> GetComic(int id)
        {
            var comics = await _comicServices.GetComicAsync(id);

            if (comics == null)
            {
                return NotFound();
            }

            return comics;
        }

        // PUT: api/Comics/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComics(int id, PutComicDTO comics)
        {
            if (id != comics.Id)
            {
                return BadRequest();
            }

            await _comicServices.ModifyComicAsync(comics);

            try
            {
                await _comicServices.SaveComicAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await _comicServices.ComicsExistsAync(id))
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
        public async Task<ActionResult> PostComics([FromBody]ComicsDTO comics)
        {
            await _comicServices.AddComicAsync(comics);
            await _comicServices.SaveComicAsync();

            return NoContent();
        }



        // DELETE: api/Comics/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComics(int id)
        {
            ComicsDTO comic = await _comicServices.GetComicAsync(id);
            if (comic == null)
            {
                return NotFound();
            }

            await _comicServices.DeleteComicAsync(comic.ToComicDelete());
            await _comicServices.SaveComicAsync();

            return NoContent();
        }
    }
}
