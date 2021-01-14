using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brotherhood.Domain.Models;

namespace Brotherhood.Repository.Interfaces
{
    public interface IChapterRepository : IBaseRepository<Chapter>
    {
        Task<IEnumerable<Chapter>> GetAllChapterAsync();
        Task AddChapter(Chapter entity);
        Task ModifiedChapter(Chapter entity);
        Task DeleteChapter(Chapter entity);
    }
}
