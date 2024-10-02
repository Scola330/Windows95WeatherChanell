using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows95WeatherChanell
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    internal class Root
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
        public double generationtime_ms { get; set; }
        public int utc_offset_seconds { get; set; }
        public required string timezone { get; set; }
        public required string timezone_abbreviation { get; set; }
        public double elevation { get; set; }
        public required CurrentUnits current_units { get; set; }
        public required Current current { get; set; }
    }

}
