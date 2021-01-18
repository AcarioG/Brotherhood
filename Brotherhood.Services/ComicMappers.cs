using Brotherhood.Domain.DTOs;
using Brotherhood.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brotherhood.Services
{
    public static class ComicMappers
    {
        public static List<ComicsDTO> ToListComicDTO(this List<Comic> comics)
        {
            List<ComicsDTO> comicDTOs = new List<ComicsDTO>();
            foreach (var comic in comics)
            {
                foreach (var comicDTO in comicDTOs)
                {
                    comicDTO.Chapters = comic.Chapters;
                    comicDTO.Cover = comic.Cover;
                    comicDTO.DateReleased = comic.DateReleased;
                    comicDTO.Title = comic.Title;
                    comicDTO.Synopsis = comic.Synopsis;
                    comicDTO.Genders = comic.Genders;
                }
            }
            return comicDTOs;
        }

        public static ComicsDTO ToComicDTO(this Comic comic)
        {
            return new ComicsDTO()
            {
                Chapters = comic.Chapters,
                Cover = comic.Cover,
                DateReleased = comic.DateReleased,
                Title = comic.Title,
                Synopsis = comic.Synopsis,
                Genders = comic.Genders.ToList()
            };
        }

        public static Comic ToComic(this ComicsDTO comic)
        {
            return new Comic()
            {
                Chapters = comic.Chapters,
                Cover = comic.Cover,
                DateReleased = comic.DateReleased,
                Title = comic.Title,
                Synopsis = comic.Synopsis,
                Genders = comic.Genders.ToList()
            };
        }

        public static Comic ToPutComic(this PutComicDTO putComic)
        {
            return new Comic()
            {
                Chapters = putComic.Chapters,
                Cover = putComic.Cover,
                DateReleased = putComic.DateReleased,
                Title = putComic.Title,
                Synopsis = putComic.Synopsis,
                Genders = putComic.Genders.ToList()
            };
        }

        public static Comic ToDeleteComic(this DeleteComicDTO deleteComic)
        {
            return new Comic()
            {
                Chapters = deleteComic.Chapters,
                Cover = deleteComic.Cover,
                DateReleased = deleteComic.DateReleased,
                Title = deleteComic.Title,
                Synopsis = deleteComic.Synopsis,
                Genders = deleteComic.Genders.ToList()
            };
        }
        public static DeleteComicDTO ToComicDelete(this ComicsDTO deleteComic)
        {
            return new DeleteComicDTO()
            {
                Chapters = deleteComic.Chapters,
                Cover = deleteComic.Cover,
                DateReleased = deleteComic.DateReleased,
                Title = deleteComic.Title,
                Synopsis = deleteComic.Synopsis,
                Genders = deleteComic.Genders.ToList()
            };
        }
    }
}
