using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSchedules.Data
{
    public class FlightSchedule
    {
        public int FlightNumber { get; set; }

        public int AirlineCode { get; set; }

        public int AircraftTypeCode { get; set; }

        public int FirstAirportCode { get; set; }

        public int FinalAirportCode { get; set; }

        public DateTime DepartureDateTime { get; set; }

        public DateTime ArrivalDateTime { get; set; }


    }
}
