using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DotNetCoreDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("HelloWorld")]
        public String HelloWorld()
        {
            return "Hello World!";
        }


        [HttpPost("HelloWorld")]
        public String HelloWorldPost()
        {
            return "Hello World Post!";
        }

        [HttpPut("HelloWorld")]
        public String HelloWorldPut()
        {
            return "Hello World Put!";
        }

        [HttpDelete("HelloWorld")]
        public String HelloWorldDelete()
        {
            return "Hello World Delete!";
        }


        [HttpGet("refreshauth")]
        public async Task<IActionResult> RefreshAuth()
        {
            return Ok();
        }

    }
}
