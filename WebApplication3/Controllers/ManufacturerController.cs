using CarHire.Service;
using CarHire_.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarHire.WebAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturerController : ControllerBase
    {
        private static ManufacturerService _manufacturerService { get; set; } = new ManufacturerService();

        [HttpGet]
        public List<Manufacturer> Get()
        {
            return _manufacturerService.GetManufacturer();
        }

        [HttpPost]
        public Manufacturer Add(Manufacturer manufacturer)
        {
            bool alreadyexist = _manufacturerService.IsAlreadyRegistered(manufacturer.ManufacturerCode);
            if (alreadyexist)
                return null;
            _manufacturerService.Add(manufacturer);
            return manufacturer;
        }
        [HttpPut]
        public Manufacturer Update(Manufacturer manufacturer)
        {
            _manufacturerService.Update(manufacturer);
            return manufacturer;
        }
        [HttpDelete]
        public Manufacturer Delete(Manufacturer manufacturer)
        {
            _manufacturerService.Delete(manufacturer);
            return manufacturer;
        }
    }   
}
