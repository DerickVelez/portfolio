using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSchedules.Data
{
    public record Airports
    {
        public int AirportCode { get; set; }

        public string AirportName { get; set; }

        public string AirportLocation { get; set; }

        public int AirportLatitude { get; set; }

        public int AirportLongtitude { get; set; }

        public int AirportElevation { get; set; }

        public string OtherDetails { get; set; }

    }
}
