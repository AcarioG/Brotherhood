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
        public string Title { get; set; }
        public byte[] Cover { get; set; }
        public DateTime DateReleased { get; set; }
        //public ICollection<GenderViewModel> Genders { get; set; }
        public string Synopsis { get; set; }
        //public virtual ICollection<ChapterViewModel> Chapters { get; set; }
    }
}
