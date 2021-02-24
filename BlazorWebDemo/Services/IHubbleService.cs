using BlazorWebDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebDemo.Services
{
    interface IHubbleService
    {
        Task<IEnumerable<HubbleImage>> GetAllImages();
        Task<HubbleImage> GetVideo(int id);
    }
}
