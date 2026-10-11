namespace Biosource.Api.DTOs;

/// <summary>
/// Represents weather forecast data returned by the API.
/// </summary>
public sealed record WeatherForecastResponse(
    DateTimeOffset Date,
    int TemperatureC,
    int TemperatureF,
    string Summary);
