using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Brotherhood.UI.Repositories
{
    public class Repository : IRepository
    {
        private readonly HttpClient _httpClient;

        public Repository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<HttpResponseWrapper<object>> Post<T>(string Url, T post)
        {
            var postJSON = JsonSerializer.Serialize(post);
            var postContent = new StringContent(postJSON, Encoding.UTF8, "application/json");
            var responseHttp = await _httpClient.PostAsync(Url, postContent);
            return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);
        }
    }
}
