using Utilities_Blazor.Models;

namespace Utilities_Blazor.Service
{
  public interface IWeatherCast
  {
    //Task<List<WorldCity> GetCityCountiesAsync(string cityName);
    Task<ForecastDto> GetWeatherAsync(decimal Latitude, decimal Longitude);
  }
}
