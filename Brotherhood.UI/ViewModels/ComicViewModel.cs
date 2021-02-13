using Brotherhood.UI.QuickType;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Brotherhood.UI.ViewModels
{
    public class ComicViewModel
    {
        public IEnumerable<ComicJson> ComicJson { get; set; } = Enumerable.Empty<ComicJson>();

        public async Task<IEnumerable<ComicJson>> GetComicsAsync(HttpResponseMessage response)
        {
            string json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ICollection<ComicJson>>(json);;
        }
    }
}
