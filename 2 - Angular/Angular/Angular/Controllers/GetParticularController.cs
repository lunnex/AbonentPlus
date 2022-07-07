using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Angular.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetParticularController : ControllerBase
    {
        [HttpGet]
        public WeatherForecast Get(int id)
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = WeatherForecastController.Summaries[rng.Next(WeatherForecastController.Summaries.Length)]
            })
            .ToArray()[id];
        }
    }
}

