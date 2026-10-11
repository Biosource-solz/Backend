using Biosource.Api.DTOs;
using Biosource.Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Biosource.Api.Controllers;

/// <summary>
/// Provides weather forecast data.
/// </summary>
[ApiController]
[Route("[controller]")]
[Produces("application/json")]
public sealed class WeatherForecastController(IWeatherForecastService weatherForecastService) : ControllerBase
{
    /// <summary>
    /// Returns a five-day weather forecast.
    /// </summary>
    /// <returns>A collection of weather forecasts.</returns>
    [HttpGet(Name = "GetWeatherForecast")]
    [ProducesResponseType<IReadOnlyList<WeatherForecastResponse>>(StatusCodes.Status200OK)]
    public async Task<ActionResult<IReadOnlyList<WeatherForecastResponse>>> Get(
        CancellationToken cancellationToken)
    {
        var forecasts = await weatherForecastService.GetUpcomingAsync(cancellationToken);
        return Ok(forecasts);
    }
}
