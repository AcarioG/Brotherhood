using Brotherhood.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brotherhood.Services.Interfaces
{
    public interface IUnitOfWorkRepository
    {
        IChapterRepository ChapterRepository { get; }
        IComicsRepository ComicsRepository { get;  }
    }
}
