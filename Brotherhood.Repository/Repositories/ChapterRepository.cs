using Brotherhood.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brotherhood.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Brotherhood.Repository.Repositories
{
    public class ChapterRepository : BaseRepository<Chapter>, IChapterRepository
    {
        public ChapterRepository(ApplicationDbContext context) 
            : base(context)
        {
        }

        public async Task<IEnumerable<Chapter>> GetAllChapterAsync()
        {
            return await GetAll();
        }

        public async Task AddChapterAsync(Chapter entity)
        {
            await Insert(entity);
        }

        public async Task<Chapter> GetChapterAsync(int Id)
        {
            return await Get(Id);
        }

        public async Task ModifyChapterAsync(Chapter entity)
        {
            await Update(entity);
        }

        public async Task DeleteChapterAsync(Chapter entity)
        {
            await Delete(entity);
        }

        public async Task<bool> SaveChapterAsync()
        {
            return await Save();
        }

    }
}
