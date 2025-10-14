using System;
using System.Threading.Tasks;
using PackIT.Application.DTO.External;
using PackIT.Application.Services;
using PackIT.Domain.ValueObjects;

namespace PackIT.Infrastructure.EF.Services
{
    internal sealed class DumbWeatherService : IWeatherService
    {
        public Task<WeatherDTO> GetWeatherAsync(Localization localization)
            => Task.FromResult(new WeatherDTO(new Random().Next(5, 30)));
    }
}