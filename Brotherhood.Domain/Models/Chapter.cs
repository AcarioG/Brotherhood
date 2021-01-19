using System;
using System.Collections.Generic;
using System.Text;

namespace Brotherhood.Domain.Models
{
    public partial class Chapter : EntityBase
    {
        public string TitleChapter { get; set; }
        public virtual ICollection<Page> Pages { get; set; }
        public virtual Comic Comic { get; set; }
    }
}
