using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brotherhood.UI.Repositories
{
    public class HttpResponseWrapper<T>
    {
        public string Message { get; set; }
        public T Record { get; set; }
        public bool IsSuccess { get; set; }
    }
}
