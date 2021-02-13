using Brotherhood.Domain.Models;
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
        private readonly HttpClient _http;

        public Repository()
        {
        }

        public Repository(HttpClient http)
        {
            _http = http;
        }

        public async Task<string> GetAsync(string url)
        {
            HttpResponseMessage response = await _http.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            return string.Empty;
        }

        public Task<string> Post(string url, string post)
        {
            throw new NotImplementedException();
        }
    }
}
