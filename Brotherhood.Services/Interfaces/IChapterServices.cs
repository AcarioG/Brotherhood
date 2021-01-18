using Brotherhood.Domain.DTOs;
using Brotherhood.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brotherhood.Services.Interfaces
{
    public interface IChapterServices
    {
        Task<IEnumerable<ChapterDTO>> GetAllChaptersAsync();
        Task<ChapterDTO> GetChapterAsync(int Id);
        Task AddChaptersAsync(ChapterDTO entity);
        Task ModifyChaptersAsync(PutChapterDTO entity);
        Task DeleteChaptersAsync(DeleteChapterDTO entity);
        Task<bool> SaveChaptersAsync();
    }
}
