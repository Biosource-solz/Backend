using Biosource.Api.Interfaces;
using Biosource.Api.Models;

namespace Biosource.Api.Data;

/// <summary>
/// Generates sample weather forecasts without persistent storage.
/// </summary>
public sealed class InMemoryWeatherForecastRepository : IWeatherForecastRepository
{
    private static readonly string[] Summaries =
    [
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    ];

    /// <summary>
    /// Retrieves five generated weather forecasts.
    /// </summary>
    public Task<IReadOnlyList<WeatherForecast>> GetUpcomingAsync(CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();

        IReadOnlyList<WeatherForecast> forecasts = Enumerable.Range(1, 5)
            .Select(index =>
            {
                var temperatureC = Random.Shared.Next(-20, 55);

                return new WeatherForecast(
                    DateTimeOffset.UtcNow.Date.AddDays(index),
                    temperatureC,
                    32 + (int)(temperatureC / 0.5556),
                    Summaries[Random.Shared.Next(Summaries.Length)]);
            })
            .ToArray();

        return Task.FromResult(forecasts);
    }
}
