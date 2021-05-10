using System;
using System.Collections.Generic;

namespace AspNetCoreVueStarter.Models
{
    public partial class X_WeatherForecasts
    {
        public int Id { get; set; }
        public int Temperature { get; set; }
        public string Summary { get; set; }
        public DateTime DateFormatted { get; set; }
    }
}
