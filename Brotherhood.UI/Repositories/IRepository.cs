using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brotherhood.UI.Repositories
{
    public interface IRepository
    {
        //Task<string> GetAsync(string url);
        Task<HttpResponseWrapper<T>> GetAsync<T>(string url);
        Task<HttpResponseWrapper<object>> Post<T>(string url, T post);
        Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T post);
    }
}
