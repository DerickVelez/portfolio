using GameStore.Service;
using GamingStore.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GamingStoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccessoriesController : ControllerBase
    {
        private static AccessoriesService _accessoriesService;
        public AccessoriesController(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DerickServer");
            _accessoriesService = new AccessoriesService(connectionString);
        }

        [HttpGet]
        public List<Accessories> Get()
        {
            return _accessoriesService.GetAccessories();

        }
        [HttpPost]
        public Accessories Add(Accessories accessories)
        {
            bool alreadyexist = _accessoriesService.IsAlreadyRegistered(accessories.AccessoryName);
            if (alreadyexist)
                return null;

            _accessoriesService.Add(accessories);
            return accessories;
        }
        [HttpPut]

        public Accessories Update(Accessories accessories)
        {
            _accessoriesService.Update(accessories);
            return accessories;
        }
        [HttpDelete]
        public Accessories Delete(Accessories accessories)
        {
            _accessoriesService.Delete(accessories);
            return accessories;
        }

      
    }
}
