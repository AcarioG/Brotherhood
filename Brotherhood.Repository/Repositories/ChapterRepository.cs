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

        public async Task<IEnumerable<Chapter>> GetAllChapter()
        {
            return await GetAll();
        }

        public async Task AddChapter(Chapter entity)
        {
            await Insert(entity);
        }

        public async Task<Chapter> GetChapter(int Id)
        {
            return await Get(Id);
        }

        public async Task ModifyChapter(Chapter entity)
        {
            await Update(entity);
        }

        public async Task DeleteChapter(Chapter entity)
        {
            await Delete(entity);
        }

        public async Task<bool> SaveChapterAsync()
        {
            return await Save();
        }
        public async Task<bool> ChapterExistAsync(int Id)
        {
            var chapter = await GetAllChapter();
            return chapter.Any(db => db.Id == Id);
        }

    }
}
