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
            _vehicleservice.Add(vehicle);
            return vehicle;
        }
    }
}
