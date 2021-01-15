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
        Task IComicServices.AddComicAsync(Comics entity)
        {
            throw new NotImplementedException();
        }

        Task IComicServices.DeleteComicAsync(Comics entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Comics>> IComicServices.GetAllComicsAsync()
        {
            throw new NotImplementedException();
        }

        Task<Comics> IComicServices.GetComicAsync(int Id)
        {
            throw new NotImplementedException();
        }

        Task IComicServices.ModifyComicAsync(Comics entity)
        {
            throw new NotImplementedException();
        }
    }
}
