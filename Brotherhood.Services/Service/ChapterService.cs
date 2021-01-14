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
        public async Task<IEnumerable<ChapterDTO>> GetChaptersAsync()
        {
            var chaptersDTO = await _unitOfWork.ChapterRepository.GetAll();
            return chaptersDTO.ToList().ToChapterDTO();
        }
    }
}
