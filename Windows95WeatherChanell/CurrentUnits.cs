using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows95WeatherChanell
{
    internal class CurrentUnits
    {
        public required string time { get; set; }
        public required string interval { get; set; }
        public required string temperature_2m { get; set; }
        public required string relative_humidity_2m { get; set; }
        public required string weather_code { get; set; }
    }
}
