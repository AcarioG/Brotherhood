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
            List<ComicsDTO> comicsDTOs = new List<ComicsDTO>();
            comics.ForEach(c =>
            {
                comicsDTOs.Add(c.ToComicDTO());
            });
            return comicsDTOs;
        }

        public static ComicsDTO ToComicDTO(this Comic comic)
        {
            return new ComicsDTO()
            {
                Id = comic.Id,
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
                Id = (int)comic.Id,
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
