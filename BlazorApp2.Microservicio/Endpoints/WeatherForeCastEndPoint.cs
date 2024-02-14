using BlazorApp2.Microservicio.Interfaces;

namespace BlazorApp2.Microservicio.Endpoints
{
    public static class WeatherForeCastEndPoint
    {
        public static void MapWeatherForecastEndPoints(this IEndpointRouteBuilder routes)
        {
            routes.MapGet("/weatherforecast", async (IWeatherForecastService weatherForecast) =>
            {
                try
                {
                    var response = await weatherForecast.GetWeatherForecast();
                    return Results.Ok(response);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return Results.Problem(ex.Message);
                }
            })
            .WithName("Weatherforecast")
            .Produces<IResult>(StatusCodes.Status200OK, "application/pdf")
            .Produces<HttpValidationProblemDetails>(StatusCodes.Status400BadRequest, "application/problem+json")
            .Produces<HttpValidationProblemDetails>(StatusCodes.Status500InternalServerError,
                "application/problem+json"); ;
        }
    }
}
