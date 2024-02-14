using BlazorApp2.Client.Interfaces;
using BlazorApp2.Client.Services;
using BlazorApp2.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;


namespace BlazorApp2.Client.Pages
{
    public partial class FetchData
    {
        //[Inject]
        //private IWeatherForecastCService _weatherForecastCService { get; set; }
        //private IEnumerable<WeatherForecast?> _forecasts;
        //private WeatherForecast[] _forecast;


        //public FetchData(IWeatherForecastCService WeatherForecastCService)
        //{
        //    _weatherForecastCService = WeatherForecastCService;
        //}

        //protected override async Task OnInitializedAsync()
        //{
        //    try
        //    {
        //        _forecasts = await _weatherForecastCService.GetForecastAsync();
        //        //forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
        //        //return _forecasts;

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);

        //    }

        //}
    }
}
