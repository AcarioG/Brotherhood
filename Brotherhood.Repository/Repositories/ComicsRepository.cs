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
    public class ComicsRepository : BaseRepository<Comic>, IComicsRepository
    {
        public ComicsRepository(ApplicationDbContext context) 
            : base(context)
        {
        }

        public async Task<IEnumerable<Comic>> GetAllComics()
        {
            return await GetAll();
        }

        public async Task<Comic> GetComic(int Id)
        {
            return await Get(Id);
        }

        public async Task AddComic(Comic entity)
        {
            await Insert(entity);
        }

        public async Task ModifyComic(Comic entity)
        {
            await Update(entity);
        }

        public async Task DeleteComic(Comic entity)
        {
            await Delete(entity);
        }

        public async Task<bool> SaveComicDbAsync()
        {
            return await Save();
        }

        public async Task<bool> ComicsExistsAsync(int Id)
        {
            var comics = await GetAllComics();
            return comics.Any(db => db.Id == Id);
        }
    }
}
