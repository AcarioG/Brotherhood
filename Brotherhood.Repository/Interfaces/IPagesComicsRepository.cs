using Brotherhood.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brotherhood.Repository.Interfaces
{
    public interface IPagesComicsRepository : IBaseRepository<PagesComics>
    {
        Task<IEnumerable<PagesComics>> GetAllPagesAsync();
        Task AddPage(PagesComics entity);
        Task ModifyPage(PagesComics entity);
        Task DeletePage(PagesComics entity);
    }
}
