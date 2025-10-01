using System.Threading.Tasks;
using PackIT.Application.DTO.External;
using PackIT.Domain.ValueObjects;

namespace PackIT.Application.Services
{
    public interface IWeatherService
    {
        Task<WeatherDTO> GetWeatherAsync(Localization localization);
    }
}