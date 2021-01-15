using Brotherhood.Domain.DTOs;
using Brotherhood.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brotherhood.Services
{
    public static class Mappers
    {
        public static List<ChapterDTO> ToChapterDTO(this List<Chapter> chapters)
        {
            List<ChapterDTO> chapterDTOs = new List<ChapterDTO>();
            foreach (var chapterDto in chapterDTOs)
            {
                foreach (var chapter in chapters)
                {
                    chapterDto.TitleChapter = chapter.TitleChapter;
                    chapterDto.Comic = chapter.Comic;
                    chapterDto.Pages = chapter.Pages;
                }
            }
            return chapterDTOs;
        }

        //public static
    }
}
