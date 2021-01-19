using Brotherhood.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brotherhood.Repository.Interfaces
{
    public interface IPagesComicsRepository : IBaseRepository<Page>
    {
        Task<IEnumerable<Page>> GetAllPagesAsync();
        Task AddPage(Page entity);
        Task ModifyPage(Page entity);
        Task DeletePage(Page entity);
        Task<bool> SavePageAsync();
    }
}
