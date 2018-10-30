using BlizzardPinCollector.API.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlizzardPinCollector.UI.Services
{
    public interface IApiClient
    {
        Task<List<Pin>> GetPinsAsync();
    }

    public class ApiClient : IApiClient
    {
        private readonly HttpClient httpClient;

        public ApiClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<Pin>> GetPinsAsync()
        {
            var response = await httpClient.GetAsync("/api/pin");

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsJsonAsync<List<Pin>>();
        }
    }
}
