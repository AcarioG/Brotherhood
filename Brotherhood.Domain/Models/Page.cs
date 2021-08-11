using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace Brotherhood.Domain.Models
{
    public partial class Page : EntityBase
    {
        public byte[] Pages { get; set; }
        [JsonIgnore]
        public virtual Chapter Chapter { get; set; }
    }
}
