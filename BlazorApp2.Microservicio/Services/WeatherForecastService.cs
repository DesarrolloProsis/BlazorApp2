using BlazorApp2.Microservicio.Interfaces;
using BlazorApp2.Shared;
using BlazorApp2.Shared.Data;
using Microsoft.EntityFrameworkCore;
using static System.Net.WebRequestMethods;

namespace BlazorApp2.Microservicio.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        public prosisdb_6testContext _dbContext { get; }

        public WeatherForecastService(prosisdb_6testContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<WeatherForecast>> GetWeatherForecast()
        {
            try
            {

                var weathers =  _dbContext.WeatherForecasts1.Where(weatherforecast => weatherforecast.Id > 0);
                var weatherList = await weathers.ToListAsync();
                List<WeatherForecast> myWeatherList = new List<WeatherForecast>();
                foreach (var weather in weatherList)
                {
                    WeatherForecast WeatherClass = new WeatherForecast();
                    WeatherClass.Date = DateOnly.FromDateTime(weather.Date);
                    WeatherClass.TemperatureC = weather.TemperatureC;
                    WeatherClass.Summary = weather.Summary;
                    myWeatherList.Add(WeatherClass);
                }
                IEnumerable<WeatherForecast> enumerableWeatherForecast = myWeatherList.AsEnumerable();
                return enumerableWeatherForecast;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
