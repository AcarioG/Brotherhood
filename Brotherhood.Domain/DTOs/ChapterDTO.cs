using Brotherhood.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brotherhood.Domain.DTOs
{
    public class ChapterDTO
    {
        public virtual ICollection<PagesComics> Pages { get; set; }
        public virtual Comics Comic { get; set; }
    }
}
