using Brotherhood.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brotherhood.Services.Interfaces
{
    public interface IComicServices
    {
        Task<IEnumerable<Comics>> GetAllComicsAsync();
        Task<Comics> GetComicAsync(int Id);
        Task AddComicAsync(Comics entity);
        Task ModifyComicAsync(Comics entity);
        Task DeleteComicAsync(Comics entity);
    }
}
