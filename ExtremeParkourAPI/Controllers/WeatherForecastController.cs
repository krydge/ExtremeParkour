using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExtremeParkour.Shared;
using ExtremeParkourAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ExtremeParkourAPI.Controllers
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
        private readonly DatabaseContext dbContext;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, DatabaseContext dbContext)
        {
            _logger = logger;
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var videos = dbContext.VideoMetaData.ToList();
            dbContext.VideoMetaData.Add(new VideoMetaData { Description = $"Created on {DateTime.Now.ToString()}", Title = $"New Video {videos.Count+1}" });
            dbContext.SaveChanges();

            return from v in videos
                   select new WeatherForecast
                   {
                       Date = DateTime.Now,
                       TemperatureC = 0,
                       Summary = v.Description
                   };

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
