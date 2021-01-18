using Brotherhood.Domain.DTOs;
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
        Task<IEnumerable<ComicsDTO>> GetAllComicsAsync();
        Task<ComicsDTO> GetComicAsync(int Id);
        Task AddComicAsync(ComicsDTO entity);
        Task ModifyComicAsync(PutComicDTO entity);
        Task DeleteComicAsync(DeleteComicDTO entity);
        Task<bool> SaveComicAsync();
        Task<bool> ComicsExistsAync(int Id);
    }
}
