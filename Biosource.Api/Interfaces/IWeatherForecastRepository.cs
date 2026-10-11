using Biosource.Api.Models;

namespace Biosource.Api.Interfaces;

/// <summary>
/// Retrieves weather forecast domain data.
/// </summary>
public interface IWeatherForecastRepository
{
    /// <summary>
    /// Retrieves the upcoming weather forecasts.
    /// </summary>
    Task<IReadOnlyList<WeatherForecast>> GetUpcomingAsync(CancellationToken cancellationToken);
}
