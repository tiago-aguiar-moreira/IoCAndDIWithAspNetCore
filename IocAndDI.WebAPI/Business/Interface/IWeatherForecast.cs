using System.Collections.Generic;
using IocAndDI.WebAPI.Model;

namespace IocAndDI.WebAPI.Business.Interface
{
    public interface IWeatherForecast
    {
        IEnumerable<WeatherForecast> ListWeatherForecast();
    }
}