using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Brotherhood.Domain.Models
{
    public class EntityBase
    {
        public EntityBase()
        {
            CreatedOn = DateTime.Now;
            ModifiedOn = DateTime.Now;
        }
        [JsonPropertyName("Id")]
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
