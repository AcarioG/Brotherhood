using Brotherhood.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brotherhood.Repository.Interfaces
{
    public interface IComicsRepository : IBaseRepository<Comics>
    {
        Task<IEnumerable<Comics>> GetAllComics();
        Task<Comics> GetComic(int Id);
        Task AddComic(Comics entity);
        Task ModifyComic(Comics entity);
        Task DeleteComic(Comics entity);
    }
}
