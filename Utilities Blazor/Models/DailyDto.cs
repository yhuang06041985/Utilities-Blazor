using System.Timers;

namespace Utilities_Blazor.Models
{
  public class DailyDto
  {
    public List<string> Time   { get; set; }
    public List<string> IconUrl { get; set; }
    public List<string> TemperatureHigh { get; set; }
    public List<string> TemperatureLow { get; set; }  

  }
}
