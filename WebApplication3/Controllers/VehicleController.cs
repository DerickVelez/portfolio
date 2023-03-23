using CarHire.Service;
using CarHire_.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarHire.WebAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private static VehicleService _vehicleservice { get; set; } = new VehicleService();

        [HttpGet]
        public List<Vehicle> Get()
        {
            return _vehicleservice.GetVehicles();
        }

        [HttpPost]
        public Vehicle Add(Vehicle vehicle)
        {
            bool alreadyexist = _vehicleservice.IsAlreadyRegistered(vehicle.RegNumber);
            if (alreadyexist)
                return null;
            _vehicleservice.Add(vehicle);
            return vehicle;
        }
        [HttpPut]
        public Vehicle Update(Vehicle vehicle)
        {
            _vehicleservice.Update(vehicle);
            return vehicle;
        }
        [HttpDelete]
        public Vehicle Delete(Vehicle vehicle)
        {
            _vehicleservice.Delete(vehicle);
            return vehicle;
        }
    }
}
