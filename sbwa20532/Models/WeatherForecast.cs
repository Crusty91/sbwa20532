using System;

namespace sbwa20532.Models
{
    public class WeatherForecast
    {
        public WeatherForecast()
        {
        }

        public WeatherForecast(DateTime date, string summary): base()
        {
            Date = date;
            Summary = summary;
        }

        public WeatherForecast(DateTime date, string summary, int temperature): this(date, summary)
        {
            TemperatureC = temperature;
            TemperatureF = 32 + (int)(TemperatureC / 0.5556);
        }

        public int WeatherForecastId { get; set; }
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public string Summary { get; set; }
        public int TemperatureF { get; set; }
    }
}
