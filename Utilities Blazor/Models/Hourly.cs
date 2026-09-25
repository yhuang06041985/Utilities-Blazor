using System.Timers;

namespace Utilities_Blazor.Models
{
  public class Hourly
  {
    public List<string> time { get; set; } = new();
    public List<double> temperature_2m { get; set; } = new();
    public List<double> apparent_temperature { get; set; } = new();
    public List<int> weather_code { get; set; } = new();
    public List<int> relative_humidity_2m { get; set; } = new();
    public List<double> wind_speed_10m { get; set; } = new();

  }
}

