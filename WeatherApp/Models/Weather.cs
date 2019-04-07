using System;

namespace WeatherApp.Models
{
    public class Weather
    {
        public DateTime time { get; set; }
        public double temp { get; set; }
        public string symbol { get; set; }
        public string desc { get; set; }
    }
}