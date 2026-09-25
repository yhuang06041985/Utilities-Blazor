using Microsoft.EntityFrameworkCore;
using Utilities_Blazor.Models;


namespace Utilities_Blazor.Data
{
  public class AppDbContext : DbContext
  {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<WorldCity> WorldCities { get; set; }
    public DbSet<WeatherCode> WeatherCodes { get; set; }  
    public DbSet<TimeHour> TimeHours { get; set; }
  }
}
