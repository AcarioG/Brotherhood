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
            return await dbSet.ToListAsync();
        }

        public async Task AddChapterAsync(Chapter entity)
        {
             await dbSet.AddAsync(entity);
        }

        public async Task ModifyChapterAsync(Chapter entity)
        {
            await Task.Run(() =>
            {
                dbSet.Update(entity).State = EntityState.Modified;
            });
            await Save();
        }

        public async Task DeleteChapterAsync(Chapter entity)
        {
            await Task.Run(() =>
            {
                dbSet.Remove(entity).State = EntityState.Deleted;
            });
            await Save();
        }

        
    }
}
