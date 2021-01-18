using Brotherhood.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brotherhood.Repository.Interfaces
{
    public interface IComicsRepository : IBaseRepository<Comic>
    {
        Task<IEnumerable<Comic>> GetAllComics();
        Task<Comic> GetComic(int Id);
        Task AddComic(Comic entity);
        Task ModifyComic(Comic entity);
        Task DeleteComic(Comic entity);
        Task<bool> SaveComicDbAsync();
        Task<bool> ComicsExistsAsync(int Id);
    }
}
