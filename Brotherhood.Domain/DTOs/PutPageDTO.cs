using Brotherhood.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brotherhood.Domain.DTOs
{
    public class PutPageDTO
    {
        public int Id { get; set; }
        public byte[] Pages { get; set; }
        public virtual Chapter Chapter { get; set; }
    }
}
