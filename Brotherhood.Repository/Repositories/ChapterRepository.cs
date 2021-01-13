using Brotherhood.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brotherhood.Domain.Models;

namespace Brotherhood.Repository.Repositories
{
    public class ChapterRepository : BaseRepository<Chapter>, IChapterRepository
    {
        public ChapterRepository(ApplicationDbContext context) 
            : base(context)
        {
        }

        public Task<IQueryable<Chapter>> GetAllChapterAsync()
        {
            throw new NotImplementedException();
        }
    }
}
