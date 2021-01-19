using Brotherhood.Domain.DTOs;
using Brotherhood.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brotherhood.Services
{
    public static class PageMappers
    {
        public static List<PagesDTO> PagesDTO(this List<Page> pages)
        {
            List<PagesDTO> pagesDTOs = new List<PagesDTO>();
            pages.ForEach(c =>
            {
                pagesDTOs.Add(c.ToPages());
            });

            return pagesDTOs;
        }
        public static PagesDTO ToPages (this Page pageDTO)
        {
            return new PagesDTO()
            {
                Chapter = pageDTO.Chapter,
                Pages = pageDTO.Pages
                
            };
        }
        public static Page ToPages(this PagesDTO pageDTO)
        {
            return new Page()
            {
                Chapter = pageDTO.Chapter,
                Pages = pageDTO.Pages

            };
        }
        public static Page ToPutChapter(this PutPageDTO putpageDTO)
        {
            return new Page()
            {
                Chapter = putpageDTO.Chapter,
                Pages = putpageDTO.Pages,
            };
        }
        public static Page ToDeletePages(this DeletePageDTO deletePage)
        {
            return new Page()
            {
                Chapter = deletePage.Chapter,
                Pages = deletePage.Pages,

            };
        }
        public static DeletePageDTO ToPageDelete(this PagesDTO deletePage)
        {
            return new DeletePageDTO()
            {
                Chapter = deletePage.Chapter,
                Pages = deletePage.Pages
            };
        }

    }
}
