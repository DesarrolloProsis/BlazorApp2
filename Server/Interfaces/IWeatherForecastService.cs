using BlazorApp2.Shared;

namespace BlazorApp2.Server.Interfaces
{
    public interface IWeatherForecastService
    {
        Task<IEnumerable<WeatherForecast>> GetForecastAsync();
    }
}