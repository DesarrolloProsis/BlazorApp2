using BlazorApp2.Shared;
using System.Net.Http;
using BlazorApp2.Server.Interfaces;

namespace BlazorApp2.Server.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private HttpClient Http { get; }

        public WeatherForecastService(IHttpClientFactory _httpClientFactory)
        {
            Http = _httpClientFactory.CreateClient("Microservicio1");
        }

        public async Task<IEnumerable<WeatherForecast>> GetForecastAsync()
        {
            try
            {
                return await Http.GetFromJsonAsync<WeatherForecast[]>("weatherforecast");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
