using ExtremeParkour.Data;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExtremeParkour.Services
{
   public interface IWeatherForecastApi
    { 
       [Get("/weatherforecast/")]
       IEnumerable<WeatherForecast> GetForecast();
   }

    public interface IExtremeParkourAPI
    {
        
    }

}
