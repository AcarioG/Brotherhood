using Brotherhood.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brotherhood.Repository.Interfaces
{
    public interface IPagesComicsRepository : IBaseRepository<PageComic>
    {
        Task<IEnumerable<PageComic>> GetAllPagesAsync();
        Task AddPage(PageComic entity);
        Task ModifyPage(PageComic entity);
        Task DeletePage(PageComic entity);
        Task<bool> SavePageAsync();
    }
}
