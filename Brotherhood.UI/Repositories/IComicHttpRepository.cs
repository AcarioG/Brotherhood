using Brotherhood.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brotherhood.UI.Repositories
{
    public interface IComicHttpRepository : IRepository
    {
        Task<IEnumerable<Comic>> GetComicsAsync(string url);
    }
}
