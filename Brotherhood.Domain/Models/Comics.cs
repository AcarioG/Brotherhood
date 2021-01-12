using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Brotherhood.Domain.Models
{
    public partial class Comics : EntityBase
    {
        public string Title { get; set; }
        public string Cover { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateReleased { get; set; }
        public virtual ICollection<Chapter> Chapters { get; set; }
    }
}
