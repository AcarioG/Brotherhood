using Brotherhood.Domain.Models;
using Brotherhood.Repository.Interfaces;
using Brotherhood.Repository.Repositories;
using Brotherhood.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brotherhood.Services.UnitOfWork
{
    public class UnitOfWorkRepository : IUnitOfWorkRepository
    {
        public IChapterRepository ChapterRepository { get; }

        public IComicsRepository ComicsRepository { get; }

        public UnitOfWorkRepository(ApplicationDbContext context)
        {
            ChapterRepository = new ChapterRepository(context);
            ComicsRepository = new ComicsRepository(context);
        }
    }
}
