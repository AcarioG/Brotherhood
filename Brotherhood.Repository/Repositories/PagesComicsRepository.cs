using Brotherhood.Domain.Models;
using Brotherhood.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brotherhood.Repository.Repositories
{
    public class PagesComicsRepository : BaseRepository<PageComic>, IPagesComicsRepository
    {
        public PagesComicsRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        Task<IEnumerable<PageComic>> IPagesComicsRepository.GetAllPagesAsync()
        {
            throw new NotImplementedException();
        }

        Task IPagesComicsRepository.AddPage(PageComic entity)
        {
            throw new NotImplementedException();
        }

        Task IPagesComicsRepository.ModifyPage(PageComic entity)
        {
            throw new NotImplementedException();
        }
        Task IPagesComicsRepository.DeletePage(PageComic entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SavePageAsync()
        {
            throw new NotImplementedException();
        }
    }
}
