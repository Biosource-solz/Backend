namespace Biosource.Api.Models;

/// <summary>
/// Represents a weather forecast in the domain.
/// </summary>
public sealed record WeatherForecast(
    DateTimeOffset Date,
    int TemperatureC,
    int TemperatureF,
    string Summary);
