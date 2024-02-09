using BlazorApp2.Server.Interfaces;
using BlazorApp2.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using static System.Net.WebRequestMethods;

namespace BlazorApp2.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private IEnumerable<WeatherForecast?> _forecasts;

        private IWeatherForecastService _weatherForecastService;

        //private static readonly string[] Summaries = new[]
        //{
        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //};

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastService weatherForecastService)
        {
            _logger = logger;
            _weatherForecastService = weatherForecastService;
        }

        [HttpGet]
        public async Task<IEnumerable<WeatherForecast?>> GetAsync()
        {
            _forecasts = await _weatherForecastService.GetForecastAsync();
            return _forecasts;

            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //})
            //.ToArray();
        }
    }
}
