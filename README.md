# Biosource Backend

ASP.NET Core Web API built with .NET 10.

## Project structure

- `Biosource.Api` - controller-based Web API
- `Biosource.slnx` - solution file

The API project groups code by responsibility:

- `Controllers/` - HTTP endpoints
- `Data/` - data access implementations
- `DTOs/` - API request and response contracts
- `Interfaces/` - service and repository abstractions
- `Middleware/` - cross-cutting HTTP error handling
- `Models/` - domain models
- `Properties/` - local launch configuration
- `Services/` - business logic and DTO mapping

## Run locally

```bash
dotnet run --project Biosource.Api
```

The API exposes the sample weather forecast endpoint at
`http://localhost:5230/WeatherForecast`.

When running in the Development environment, interactive API documentation is
available at:

`http://localhost:5230/scalar/v1`

The generated OpenAPI document is also available at:

`http://localhost:5230/openapi/v1.json`

The Scalar page provides a browser-based interface for browsing and testing API
endpoints.

## Build

```bash
dotnet build Biosource.slnx
```