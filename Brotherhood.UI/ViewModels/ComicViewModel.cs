using Brotherhood.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Http;

namespace Brotherhood.UI.ViewModels
{
    public class ComicViewModel
    {
        public async Task<IEnumerable<ComicsDTO>> GetComicsAsync()
        {
            throw await;
        }
    }
}
