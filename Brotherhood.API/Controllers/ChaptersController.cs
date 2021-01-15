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
            var chapters = await _chapterServices.GetChaptersAsync();
            return Ok(chapters);
        }

        [HttpPost]
        public async Task<IActionResult> AddChapters(ChapterDTO entity)
        {
            await _chapterServices.AddChaptersAsync(entity);
            return NoContent();
        }
}
}
