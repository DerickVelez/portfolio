using FlightSchedules.Data;
using FlightSchedules.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightScheduleWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RefAirlinesController : ControllerBase
    {
          
        public static RefAirlinesService _refAirlinesServiceList = new RefAirlinesService();

        [HttpGet]

        public List<RefAirlines> Get()
        {
            return _refAirlinesServiceList.GetRefAirlines();
        }
        [HttpPost]

        public RefAirlines Add(RefAirlines refAirlines)
        {
            bool alreadyexist = _refAirlinesServiceList.IsAlreadyRegistered(refAirlines.Airlinecode);
            if (alreadyexist)
                return null;
            _refAirlinesServiceList.Add(refAirlines);
            return refAirlines;
        }
        [HttpPut]
        public RefAirlines Update(RefAirlines refAirlines)
        {

            _refAirlinesServiceList.Update(refAirlines);
            return refAirlines;
        }


        [HttpDelete]
        public RefAirlines Delete(RefAirlines refAirlines)
        {
            _refAirlinesServiceList.Delete(refAirlines);
            return refAirlines;
        }
    }
}
