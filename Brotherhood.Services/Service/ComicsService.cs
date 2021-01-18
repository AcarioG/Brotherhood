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
    public class ComicsService : IComicServices
    {
        private readonly IUnitOfWorkRepository _unitOfWork;
        public ComicsService(IUnitOfWorkRepository unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task AddComicAsync(ComicsDTO entity)
        {
            await _unitOfWork.ComicsRepository.AddComic(entity.ToComic());
        }

        public async Task<bool> ComicsExistsAync(int Id)
        {
            return await _unitOfWork.ComicsRepository.ComicsExistsAsync(Id);
        }

        public async Task DeleteComicAsync(DeleteComicDTO entity)
        {
            await _unitOfWork.ComicsRepository.DeleteComic(entity.ToDeleteComic());
        }

        public async Task<IEnumerable<ComicsDTO>> GetAllComicsAsync()
        {
            var comicsDTOS = await _unitOfWork.ComicsRepository.GetAllComics();
            return comicsDTOS.ToList().ToListComicDTO();
        }

        public async Task<ComicsDTO> GetComicAsync(int Id)
        {
            Comic comic = await _unitOfWork.ComicsRepository.GetComic(Id);
            return comic.ToComicDTO();
        }

        public async Task ModifyComicAsync(PutComicDTO entity)
        {
            await _unitOfWork.ComicsRepository.ModifyComic(entity.ToPutComic());
        }

        public async Task<bool> SaveComicAsync()
        {
            return await _unitOfWork.ComicsRepository.SaveComicDbAsync();
        }
    }
}
