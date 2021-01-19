using Brotherhood.Domain.Models;
using Brotherhood.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brotherhood.Repository.Repositories
{
    public class PagesComicsRepository : BaseRepository<Page>, IPagesComicsRepository
    {
        public PagesComicsRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        Task<IEnumerable<Page>> IPagesComicsRepository.GetAllPagesAsync()
        {
            throw new NotImplementedException();
        }

        Task IPagesComicsRepository.AddPage(Page entity)
        {
            throw new NotImplementedException();
        }

        Task IPagesComicsRepository.ModifyPage(Page entity)
        {
            throw new NotImplementedException();
        }
        Task IPagesComicsRepository.DeletePage(Page entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SavePageAsync()
        {
            throw new NotImplementedException();
        }
    }
}
