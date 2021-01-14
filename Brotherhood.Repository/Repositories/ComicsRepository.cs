using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brotherhood.Domain.Models;
using Brotherhood.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Brotherhood.Repository.Repositories
{
    public class ComicsRepository : BaseRepository<Comics>, IComicsRepository
    {
        public ComicsRepository(ApplicationDbContext context) 
            : base(context)
        {
        }

        public async Task<IEnumerable<Comics>> GetAllComics()
        {
            return await dbSet.ToListAsync();
        }

        public async Task<Comics> GetComic(int Id)
        {
            return await dbSet.FindAsync(Id);
        }

        public async Task AddComic(Comics entity)
        {
            await dbSet.AddAsync(entity);
            await Save();
        }

        public async Task ModifyComic(Comics entity)
        {
            await Task.Run(() =>
            {
                dbSet.Update(entity).State = EntityState.Modified;
            });
            await Save();
        }

        public async Task DeleteComic(Comics entity)
        {
            await Task.Run(() =>
            {
                dbSet.Remove(entity).State = EntityState.Deleted;
            });

            await Save();
        }
    }
}
