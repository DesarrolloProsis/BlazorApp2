using BlazorApp2.Client.Interfaces;
using BlazorApp2.Shared;
using System.Net.Http.Json;

namespace BlazorApp2.Client.Services
{
    public class WeatherForecastCService : IWeatherForecastCService
    {
        //private HttpClient Http { get; }
        private HttpClient _httpClient;

        //public WeatherForecastCService(IHttpClientFactory _httpClientFactory)
        public WeatherForecastCService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<WeatherForecast>> GetForecastAsync()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<WeatherForecast[]>("weatherforecast");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
