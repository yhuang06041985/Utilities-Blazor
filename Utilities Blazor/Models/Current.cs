using System.Timers;

namespace Utilities_Blazor.Models
{
  public class Current
  {
    public string? time { get; set; }
    public decimal temperature_2m { get; set; }
    public decimal apparent_temperature { get; set; }
    public int weather_code { get; set; }
    public decimal? wind_speed_10m { get; set; }
    public int relative_humidity_2m { get; private set; }

    public int precipitation { get; protected set; }

  }
}

