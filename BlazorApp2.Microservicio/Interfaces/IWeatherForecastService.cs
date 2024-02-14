using BlazorApp2.Shared;

namespace BlazorApp2.Microservicio.Interfaces
{
    public interface IWeatherForecastService
    {
        Task<IEnumerable<WeatherForecast>> GetWeatherForecast();
    }
}
