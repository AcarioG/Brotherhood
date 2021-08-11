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

        private JsonSerializerOptions JSONoptions =>
            new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

        public async Task<HttpResponseWrapper<T>> GetAsync<T>(string url)
        {
            var responseHTTP = await _http.GetAsync(url);

            if (responseHTTP.IsSuccessStatusCode)
            {
                var response = await DeserializeResponse<T>(responseHTTP, JSONoptions);
                return new HttpResponseWrapper<T>(response, false, responseHTTP);
            }
            else
            {
                return new HttpResponseWrapper<T>(default, true, responseHTTP);
            }
        }

        //public async Task<string> GetAsync(string url)
        //{
        //    HttpResponseMessage response = await _http.GetAsync(url);
        //    if (response.IsSuccessStatusCode)
        //    {
        //        return await response.Content.ReadAsStringAsync();
        //    }
        //    return string.Empty;
        //}
        public async Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T post)
        {
            var Json = JsonSerializer.Serialize(post);
            var Content = new StringContent(Json, Encoding.UTF8, "application/json");
            var responseHttp = await _http.PostAsync(url, Content);
            if (responseHttp.IsSuccessStatusCode)
            {
                var response = await DeserializeResponse<TResponse>(responseHttp, JSONoptions);
                return new HttpResponseWrapper<TResponse>(response, false, responseHttp);
            }
            else
            {
                return new HttpResponseWrapper<TResponse>(default, true, responseHttp);
            }
        }

        public async Task<HttpResponseWrapper<object>> Post<T>(string url, T post)
        {
            var Json = JsonSerializer.Serialize(post);
            var Content = new StringContent(Json, Encoding.UTF8, "application/json");
            var responseHttp = await _http.PostAsync(url, Content);
            return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);
        }

        private async Task<T> DeserializeResponse<T>(HttpResponseMessage httpResponse, JsonSerializerOptions serializerOptions)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseString, serializerOptions);
        }
    }
}
