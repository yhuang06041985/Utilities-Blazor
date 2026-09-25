namespace Utilities_Blazor.Models
{
  public class WeatherResponse
  {
    public Current Current { get; set; } = new();

    public Hourly Hourly { get; set; } = new();

    public Daily Daily { get; set; } = new();
  }
}
