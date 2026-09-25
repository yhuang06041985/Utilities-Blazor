using Utilities_Blazor.Models;

namespace Utilities_Blazor.Service
{
  public interface IDataFormat
  {
    CurrentDto FormatCurrentData(Current currentWeather, CurrentDto currentData);
    HourlyDto FormatHourlyData(Hourly hourlyWeather, HourlyDto hourlyData);
    DailyDto FormatDailyData(Daily dailyWeather, DailyDto dailyData);
  }
}
