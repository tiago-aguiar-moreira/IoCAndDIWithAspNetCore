using System.Collections.Generic;
using IocAndDI.WebAPI.Business.Interface;
using IocAndDI.WebAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace IocAndDI.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecast1Controller : ControllerBase
    {
        private readonly ILogger<WeatherForecast1Controller> _logger;

        public WeatherForecast1Controller(ILogger<WeatherForecast1Controller> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get([FromServices] IWeatherForecast weatherForecast)
            => weatherForecast.ListWeatherForecast();
    }
}
