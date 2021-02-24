using BlazorWebDemo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorWebDemo.Services
{
    public class HubbleService : IHubbleService
    {
        private readonly HttpClient httpClient;

        public HubbleService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        
        public async Task<IEnumerable<HubbleImage>> GetAllImages()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<HubbleImage>>($"https://hubblesite.org/api/v3/videos/all?page=all");
        }

        public Task<HubbleImage> GetVideo(int id)
        {
            throw new NotImplementedException();
        }
    }
}
