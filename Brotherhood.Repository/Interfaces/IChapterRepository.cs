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
        Task<IEnumerable<Chapter>> GetAllChapter();
        Task<Chapter> GetChapter(int Id);
        Task AddChapter(Chapter entity);
        Task ModifyChapter(Chapter entity);
        Task DeleteChapter(Chapter entity);
        Task<bool> SaveChapterAsync();
        Task<bool> ChapterExistAsync(int Id);
    }
}
