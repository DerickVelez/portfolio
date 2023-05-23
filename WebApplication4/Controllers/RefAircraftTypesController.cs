using FlightSchedules.Data;
using FlightSchedules.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightScheduleWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RefAircraftTypesController : ControllerBase
    {
        public static RefAircraftTypesService _refAircraftTypesServiceList = new RefAircraftTypesService();

        [HttpGet]
        public List<RefAircraftTypes> Get()
        {
            return _refAircraftTypesServiceList.GetRefAircraft();
        }

        [HttpPost]
        public RefAircraftTypes Add(RefAircraftTypes refAircraftTypes)
        {
            bool alreadyexist = _refAircraftTypesServiceList.IsAlreadyRegistered(refAircraftTypes.AircraftTypeCode);
            if (alreadyexist)
                return null;
            _refAircraftTypesServiceList.Add(refAircraftTypes);
            return refAircraftTypes;
        }

        [HttpPut]
        public RefAircraftTypes Update(RefAircraftTypes refAircraftTypes)
        {

            _refAircraftTypesServiceList.Update(refAircraftTypes);
            return refAircraftTypes;
        }

        [HttpDelete]
        public RefAircraftTypes Delete(RefAircraftTypes flightSchedule)
        {
            _refAircraftTypesServiceList.Delete(flightSchedule);
            return flightSchedule;
        }
    }
}
