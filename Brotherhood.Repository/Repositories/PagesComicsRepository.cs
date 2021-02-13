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

        public async Task AddPage(Page entity)
        {
            throw new NotImplementedException();
        }

        public async Task DeletePage(Page entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Page>> GetAllPagesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task ModifyPage(Page entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SavePageAsync()
        {
            throw new NotImplementedException();
        }
    }
}
