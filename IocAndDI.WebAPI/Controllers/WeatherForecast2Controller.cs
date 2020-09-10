using System.Collections.Generic;
using IocAndDI.WebAPI.Business.Interface;
using IocAndDI.WebAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace IocAndDI.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecast2Controller : ControllerBase
    {
        private readonly ILogger<WeatherForecast2Controller> _logger;
        private readonly IWeatherForecast _weatherForecast;

        public WeatherForecast2Controller(ILogger<WeatherForecast2Controller> logger, IWeatherForecast weatherForecast)
        {
            _logger = logger;
            _weatherForecast = weatherForecast;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
            => _weatherForecast.ListWeatherForecast();
    }
}
