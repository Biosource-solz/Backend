using Biosource.Api.DTOs;

namespace Biosource.Api.Interfaces;

/// <summary>
/// Provides weather forecast data for API endpoints.
/// </summary>
public interface IWeatherForecastService
{
    /// <summary>
    /// Gets upcoming weather forecasts formatted for API responses.
    /// </summary>
    Task<IReadOnlyList<WeatherForecastResponse>> GetUpcomingAsync(CancellationToken cancellationToken);
}
