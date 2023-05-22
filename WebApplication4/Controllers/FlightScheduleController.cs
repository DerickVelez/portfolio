using FlightSchedules.Data;
using FlightSchedules.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightScheduleWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightScheduleController : ControllerBase
    {
            public static FlightSchedulesService _flightscheduleList = new FlightSchedulesService();

            [HttpGet]
            public List<FlightSchedule> Get()
            {
                return _flightscheduleList.GetFlightSchedules();
            }
        
            [HttpPost]
            public FlightSchedule Add(FlightSchedule flightSchedule)
            {
                bool alreadyexist = _flightscheduleList.IsAlreadyRegistered(flightSchedule.FlightNumber);
                if (alreadyexist)
                    return null;
                _flightscheduleList.Add(flightSchedule);
                return flightSchedule;
            }

            [HttpPut]
            public FlightSchedule Update(FlightSchedule flightSchedule)
            {
                _flightscheduleList.Update(flightSchedule);
                return flightSchedule;
            }


            [HttpDelete]
            public FlightSchedule Delete(FlightSchedule flightSchedule)
            {
                _flightscheduleList.Delete(flightSchedule); 
                return flightSchedule;
            }
    }
}
