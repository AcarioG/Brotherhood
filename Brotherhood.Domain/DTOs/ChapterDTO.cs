using Brotherhood.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Brotherhood.Domain.DTOs
{
    public class ChapterDTO
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }
        public string TitleChapter { get; set; }
        public virtual ICollection<Page> Pages { get; set; }
        [JsonIgnore]
        public virtual Comic Comic { get; set; }
    }
}
