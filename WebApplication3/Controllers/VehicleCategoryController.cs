using CarHire.Service;
using CarHire_.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarHire.WebAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleCategoryController : ControllerBase
    {
        private static VehicleCategoryService _vehiclecategoryservice { get; set; } = new VehicleCategoryService();

        [HttpGet]
        public List<VehicleCategory> GetVehicleCategory()
        {
            return _vehiclecategoryservice.GetVehicleCategory();
        }
        [HttpPost]
        public VehicleCategory Add(VehicleCategory vehiclecategory)
        {
            _vehiclecategoryservice.Add(vehiclecategory);
                return vehiclecategory;
        }
        [HttpPut]
        public VehicleCategory Update(VehicleCategory vehiclecategory)
        {
            _vehiclecategoryservice.Update(vehiclecategory);
            return vehiclecategory;
        }
        [HttpDelete]
        public VehicleCategory Delete(VehicleCategory vehicleCategory)
        {
            _vehiclecategoryservice.Delete(vehicleCategory);
            return vehicleCategory;
        }
    }
}
