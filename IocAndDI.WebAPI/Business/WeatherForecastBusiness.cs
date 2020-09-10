using System;
using System.Collections.Generic;
using System.Linq;
using IocAndDI.WebAPI.Business.Interface;
using IocAndDI.WebAPI.Model;

namespace IocAndDI.WebAPI.Business
{
    public class WeatherForecastBusiness : IWeatherForecast
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public WeatherForecastBusiness()
        {
            
        }

        public IEnumerable<WeatherForecast> ListWeatherForecast()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }
    }
}