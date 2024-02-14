using BlazorApp2.Shared;

namespace BlazorApp2.Client.Interfaces
{
    public interface IWeatherForecastCService
    {
        Task<IEnumerable<WeatherForecast>> GetForecastAsync();
    }
}