using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brotherhood.UI.Repositories
{
    public interface IRepository
    {
        Task<string> GetAsync(string url);
        Task<string> Post(string url, string post);
    }
}
