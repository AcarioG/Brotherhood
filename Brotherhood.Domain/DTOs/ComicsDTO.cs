using Brotherhood.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brotherhood.Domain.DTOs
{
    public class ComicsDTO
    {
        public string Title { get; set; }
        public byte[] Cover { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateReleased { get; set; }
        public string Genders { get; set; }
        public string Synopsis { get; set; }
        public virtual ICollection<Chapter> Chapters { get; set; }
    }
}
