using Brotherhood.Domain.DTOs;
using Brotherhood.Domain.Models;
using Brotherhood.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        [HttpGet ("{Id}")]
        public async Task<ActionResult<ChapterDTO>> GetChapter(int Id)
        {
            var chapter = await _chapterServices.GetChapterAsync(Id);

            if (chapter == null)
            {
                return NotFound();
            }

            return chapter;
        }

        [HttpPost]
        public async Task<IActionResult> AddChapters(ChapterDTO entity)
        {
            await _chapterServices.AddChaptersAsync(entity);
            await _chapterServices.SaveChaptersAsync();

            return NoContent();
        }
}
}
