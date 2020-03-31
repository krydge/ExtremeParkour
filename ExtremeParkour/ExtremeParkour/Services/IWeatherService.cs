using ExtremeParkour.Shared;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExtremeParkour.Services
{
    public interface IWeatherService
    {
        [Get("/weatherforecast")]
        Task<IEnumerable<WeatherForecast>> GetForecastAsync();
    }
}
