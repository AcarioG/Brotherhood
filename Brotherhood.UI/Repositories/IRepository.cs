using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brotherhood.UI.Repositories
{
    public interface IRepository
    {
        Task<HttpResponseWrapper<object>> Post<T>(string Url, T post);
    }
}
