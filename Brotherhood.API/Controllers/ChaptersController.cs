using Brotherhood.Domain.DTOs;
using Brotherhood.Domain.Models;
using Brotherhood.Services;
using Brotherhood.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Brotherhood.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChaptersController : ControllerBase
    {
        private readonly IChapterServices _chapterServices;
        public ChaptersController(IChapterServices chapterServices)
        {
            _chapterServices = chapterServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var chapters = await _chapterServices.GetAllChaptersAsync();
            return Ok(chapters);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<ChapterDTO>> GetChapter(int Id)
        {
            var chapter = await _chapterServices.GetChapterAsync(Id);

            if (chapter == null)
            {
                return NotFound();
            }

            return chapter;
        }

        [HttpPut]
        public async Task<IActionResult> PutChapter(int Id, PutChapterDTO chapter)
        {
            if (Id != chapter.Id)
            {
                return BadRequest();
            }

            await _chapterServices.ModifyChaptersAsync(chapter);

            try
            {
                await _chapterServices.SaveChaptersAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await _chapterServices.ChapterExistAsync(Id))
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

        [HttpPost]
        public async Task<IActionResult> AddChapters([FromBody]ChapterDTO chapter)
        {



            await _chapterServices.AddChaptersAsync(chapter);
            //await _chapterServices.SaveChaptersAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChapters(int id)
        {
            ChapterDTO chapter = await _chapterServices.GetChapterAsync(id);
            if (chapter == null)
            {
                return NotFound();
            }

            await _chapterServices.DeleteChaptersAsync(chapter.ToChapterDelete());
            await _chapterServices.SaveChaptersAsync();

            return NoContent();
        }
    }
}
