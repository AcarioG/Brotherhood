using System;
using System.Collections.Generic;
using System.Text;

namespace Brotherhood.Domain.Models
{
    public class EntityBase
    {
        public EntityBase()
        {
            CreatedOn = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
