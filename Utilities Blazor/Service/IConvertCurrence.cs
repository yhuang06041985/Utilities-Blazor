using static Utilities_Blazor.Service.ConvertCurrence;

namespace Utilities_Blazor.Service
{
  public interface IConvertCurrence
  {
    Task<decimal> GetConversionRateAsync(string fromCurrency, string toCurrency, decimal amount);
  }
}
