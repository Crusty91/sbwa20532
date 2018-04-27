using Microsoft.AspNetCore.Mvc;
using sbwa20532.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace sbwa20532.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private readonly WeatherForecastContext _context;

        public SampleDataController(WeatherForecastContext context)
        {
            _context = context;
        }

        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts()
        {
            return _context.WeatherForecast.ToList();
        }
    }
}
