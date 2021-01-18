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
        Task<Chapter> GetChapterAsync(int Id);
        Task AddChapterAsync(Chapter entity);
        Task ModifyChapterAsync(Chapter entity);
        Task DeleteChapterAsync(Chapter entity);
        Task<bool> SaveChapterAsync();
    }
}
