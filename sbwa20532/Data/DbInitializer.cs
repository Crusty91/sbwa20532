using sbwa20532.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace sbwa20532.Data
{
    public class DbInitializer
    {
        public static void Initialize(WeatherForecastContext context)
        {
            context.Database.EnsureCreated();
            if (context.WeatherForecast.Any())
            {
                return;
            }

            string[] Summaries = new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };

            var rng = new Random();
            var forecasts = new List<WeatherForecast>();
            for (int i = 0; i < 10; i++)
            {
                forecasts.Add(
                    new WeatherForecast(
                        DateTime.Now.AddDays(i),
                        Summaries[rng.Next(Summaries.Length)],
                        rng.Next(-20, 55)));
            }

            foreach (WeatherForecast w in forecasts)
            {
                context.WeatherForecast.Add(w);
            }
            context.SaveChanges();
        }
    }
}
