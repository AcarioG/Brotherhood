using Brotherhood.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brotherhood.Domain.DTOs
{
    public class DeleteChapterDTO
    {
        public int Id { get; set; }
        public string TitleChapter { get; set; }
        public virtual ICollection<Page> Pages { get; set; }
        public virtual Comic Comic { get; set; }
    }
}
