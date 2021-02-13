using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace Brotherhood.Domain.Models
{
    public partial class Comic : EntityBase
    {
        [JsonPropertyName("Title")]
        public string Title { get; set; }
        [JsonPropertyName("Cover")]
        public string Cover { get; set; }
        [DataType(DataType.Date)]
        [JsonPropertyName("DateReleased")]
        public DateTime DateReleased { get; set; }
        [JsonPropertyName("Genders")]
        public virtual ICollection<Gender> Genders { get; set; }
        [JsonPropertyName("Synopsis")]
        public string Synopsis { get; set; }
        [JsonPropertyName("Chapters")]
        public virtual ICollection<Chapter> Chapters { get; set; }
    }
}
