using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSchedules.Data
{
    public class Legs
    {
        public int LegID { get; set; }

        public int LegSequence { get; set; }

        public int FlightNumber { get; set; }

        public int LegOriginAiportCode { get; set; }

        public int LegDestinationAirportCode { get; set; }

        public DateTime DepartureTime { get; set; }

        public DateTime ArrivalTime { get; set; }


    }
}
