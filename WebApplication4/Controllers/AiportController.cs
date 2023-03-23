using FlightSchedules.Data;
using FlightSchedules.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightScheduleWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AiportController : ControllerBase
    {
        public static AirportService _airportServiceList = new AirportService();

        [HttpGet]
        
          public List<Airports> Get()
        {
            return _airportServiceList.GetAirports();
        }

        [HttpPost]
        public Airports Add(Airports airports)
        {
            var alreadyexist = _airportServiceList.IsAlreadyRegistered(airports.AirportCode);
            if (alreadyexist)
                return null;
            _airportServiceList.Add(airports);
            return airports;
        }
        [HttpPut]
        public Airports Update(Airports airports)
        {
            _airportServiceList.Update(airports);
            return airports;
        }

        [HttpDelete]

        public Airports Delete(Airports airports)
        {
            _airportServiceList.Delete(airports);
            return airports ;
        }

    }
}
