using FlightSchedules.Data;
using FlightSchedules.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightScheduleWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LegsController : ControllerBase
    {
        public static LegsService _LegsServiceList = new LegsService();

        [HttpGet]

        public List<Legs> Get()
        {
            return _LegsServiceList.GetLegs();
        }
        [HttpPost]

        public Legs Add(Legs legs)
        {
            bool alreadyexist = _LegsServiceList.IsAlreadyRegistered(legs.LegID);
            if (alreadyexist)
                return null;
            _LegsServiceList.Add(legs);
            return legs;
        }
        [HttpPut]
        public Legs  Update(Legs legs)
        {

            _LegsServiceList.Update(legs);
            return legs;
        }


        [HttpDelete]
        public Legs Delete(Legs legs)
        {
            _LegsServiceList.Delete(legs);
            return legs;
        }
    }
}
