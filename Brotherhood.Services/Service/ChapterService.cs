using Brotherhood.Domain.DTOs;
using Brotherhood.Domain.Models;
using Brotherhood.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brotherhood.Services.Service
{
    public class ChapterService : IChapterServices
    {
        private readonly IUnitOfWorkRepository _unitOfWork;
        public ChapterService(IUnitOfWorkRepository unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddChaptersAsync(ChapterDTO entity)
        {
            await _unitOfWork.ChapterRepository.AddChapterAsync(entity.ToChapter());
        }

        public async Task DeleteChaptersAsync(DeleteChapterDTO entity)
        {
            await _unitOfWork.ChapterRepository.DeleteChapterAsync(entity.ToDeleteChapter());
        }

        public async Task<IEnumerable<ChapterDTO>> GetAllChaptersAsync()
        {
            var chaptersDTO = await _unitOfWork.ChapterRepository.GetAllChapterAsync();
            return chaptersDTO.ToList().ToListChapterDTO();
        }

        public async Task<ChapterDTO> GetChapterAsync(int Id)
        {
            Chapter chapter = await _unitOfWork.ChapterRepository.GetChapterAsync(Id);
            return chapter.ToChapter();
        }

        public async Task ModifyChaptersAsync(PutChapterDTO entity)
        {
            await _unitOfWork.ChapterRepository.ModifyChapterAsync(entity.ToPutChapter());
        }

        public async Task<bool> SaveChaptersAsync()
        {
            return await _unitOfWork.ChapterRepository.SaveChapterAsync();
        }
    }
}
