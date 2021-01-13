using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brotherhood.Domain.Models;
using Brotherhood.Repository.Interfaces;

namespace Brotherhood.Repository.Repositories
{
    public class ComicsRepository : BaseRepository<Comics>, IComicsRepository
    {
        public ComicsRepository(ApplicationDbContext context) 
            : base(context)
        {
        }

    }
}
