using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HarrPotterBackend.Services
{
    public class CRUDService : IIntegrationService
    {
        private static HttpClient _httpClient = new HttpClient();
        public CRUDService()
        {
            _httpClient.BaseAddress = new Uri("https://www.potterapi.com/v1/");
            _httpClient.Timeout = new TimeSpan(0, 0, 30);
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add();
        }
        public async Task Run()
        {
            await GetResource();
        }
        public async Task GetResource()
        {
            var response = await _httpClient.GetAsync("/characters");

            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var characters = JsonConvert.DeserializeObject<IEnumerable<characters>>(content);
        }
    }
}