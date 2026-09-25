using System.Timers;

namespace Utilities_Blazor.Models
{
  public class Daily
  {
    public List<string> time { get; set; } = new();
    public List<int> weather_code { get; set; } = new();
    public List<double> temperature_2m_max { get; set; } = new();
    public List<double> temperature_2m_min { get; set; } = new();
  }
}
