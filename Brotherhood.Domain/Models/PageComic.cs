using System;
using System.Collections.Generic;
using System.Text;

namespace Brotherhood.Domain.Models
{
    public partial class PageComic : EntityBase
    {
        public byte Pages { get; set; }
        public virtual Chapter Chapter { get; set; }
    }
}
