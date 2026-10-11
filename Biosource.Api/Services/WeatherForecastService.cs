using Biosource.Api.DTOs;
using Biosource.Api.Interfaces;

namespace Biosource.Api.Services;

/// <summary>
/// Maps weather forecast domain data to API response contracts.
/// </summary>
public sealed class WeatherForecastService : IWeatherForecastService
{
    private readonly IWeatherForecastRepository weatherForecastRepository;

    /// <summary>
    /// Initializes a weather forecast service.
    /// </summary>
    public WeatherForecastService(IWeatherForecastRepository weatherForecastRepository)
    {
        this.weatherForecastRepository = weatherForecastRepository;
    }

    /// <summary>
    /// Gets upcoming weather forecasts formatted for API responses.
    /// </summary>
    public async Task<IReadOnlyList<WeatherForecastResponse>> GetUpcomingAsync(
        CancellationToken cancellationToken)
    {
        var forecasts = await weatherForecastRepository.GetUpcomingAsync(cancellationToken);

        return forecasts
            .Select(forecast => new WeatherForecastResponse(
                forecast.Date,
                forecast.TemperatureC,
                forecast.TemperatureF,
                forecast.Summary))
            .ToArray();
    }
}
