using System.Collections.Generic;
using IocAndDI.WebAPI.Business.Interface;
using IocAndDI.WebAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace IocAndDI.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get([FromServices] IWeatherForecast weatherForecast)
            => weatherForecast.ListWeatherForecast();
    }
}
