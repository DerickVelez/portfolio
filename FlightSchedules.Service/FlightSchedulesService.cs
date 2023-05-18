using FlightSchedules.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSchedules.Service
{
    public class FlightSchedulesService
    {
        private List<FlightSchedule> flightscheduleServiceList = new List<FlightSchedule>
        {
            new FlightSchedule
            {
                FlightNumber = 545,


                AircraftTypeCode = 2,
                AirlineCode = 56,
                ArrivalDateTime = new DateTime(2021, 02, 12),
                DepartureDateTime = new DateTime(2021, 11, 21),
                FinalAirportCode = 455,
                FirstAirportCode  = 54,

            }
        };

        public bool IsAlreadyRegistered(int flightNumber)
        {
            var flightSchedule = flightscheduleServiceList.Where(a => a.FlightNumber == flightNumber).FirstOrDefault();
            return flightSchedule != null;
        }

        public List<FlightSchedule> GetFlightSchedules()
        {
            return flightscheduleServiceList;
        }

        public void Add(FlightSchedule flightSchedule)
        {
            flightscheduleServiceList.Add(flightSchedule);
        }

        public List<FlightSchedule> Delete(FlightSchedule flightschedule)
        {
            var updatedSchedule = flightscheduleServiceList.Where(a => a.FlightNumber == flightschedule.FlightNumber).FirstOrDefault();
            flightscheduleServiceList.Remove(updatedSchedule);
            return flightscheduleServiceList;
        }

        public void Update(FlightSchedule flightschedule)
        {
            Delete(flightschedule);
            flightscheduleServiceList.Add(flightschedule);
        }
    }


}
