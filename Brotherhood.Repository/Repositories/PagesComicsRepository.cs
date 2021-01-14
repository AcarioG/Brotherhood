using Brotherhood.Domain.Models;
using Brotherhood.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brotherhood.Repository.Repositories
{
    public class PagesComicsRepository : BaseRepository<PagesComics>, IPagesComicsRepository
    {
        public PagesComicsRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        Task<IEnumerable<PagesComics>> IPagesComicsRepository.GetAllPagesAsync()
        {
            throw new NotImplementedException();
        }

        Task IPagesComicsRepository.AddPage(PagesComics entity)
        {
            throw new NotImplementedException();
        }

        Task IPagesComicsRepository.ModifyPage(PagesComics entity)
        {
            throw new NotImplementedException();
        }
        Task IPagesComicsRepository.DeletePage(PagesComics entity)
        {
            throw new NotImplementedException();
        }
    }
}
