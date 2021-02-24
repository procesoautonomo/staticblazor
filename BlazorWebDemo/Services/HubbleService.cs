using BlazorWebDemo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
            return JsonConvert.DeserializeObject<IEnumerable<HubbleImage>>(await httpClient.GetStringAsync($"videos/all?page=all"));
        }

        public Task<HubbleImage> GetVideo(int id)
        {
            throw new NotImplementedException();
        }
    }
}
