using FlightSchedules.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSchedules.Service
{
    public class AirportService
    {

        public List<Airports> airportServiceList = new List<Airports>
        {
            new Airports
            {
                AirportCode = 56,
                AirportName = "NAIA",
                AirportElevation = 45,
                AirportLatitude = 545,
                OtherDetails = "dfk",
                AirportLocation = "Manila",
                AirportLongtitude = 454,

            }
        };

        public bool IsAlreadyRegistered(int airportCode)
        {
            var airport =  airportServiceList.Where(a => a.AirportCode == airportCode).FirstOrDefault();
            return airport != null;
        }
         
        public List<Airports> GetAirports()
        {
            return airportServiceList;
        }
        public void Add(Airports airports)
        {
            airportServiceList.Add(airports);
        }

        public void Delete(Airports airports)
        {
            var updatedairport = airportServiceList.Where(a => a.AirportCode == airports.AirportCode).FirstOrDefault();
            airportServiceList.Remove(updatedairport);
        }

        public void Update(Airports airports)
        {
            var updatedairport = airportServiceList.Where(a => a.AirportCode == airports.AirportCode).FirstOrDefault();
            airportServiceList.Remove(updatedairport);
            airportServiceList.Add(airports);
        }
    }
}
