using GameStore.Service;
using GamingStore.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GamingStoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccessoriesController : ControllerBase
    {
        private static AccessoriesService _accessoriesService { get; set; } = new AccessoriesService();

        [HttpGet]
        public List<Accessories> Get()
        {
            return _accessoriesService.GetAccessories();

        }
        [HttpPost]
        public Accessories Add(Accessories accessories)
        {
            _accessoriesService.Add(accessories);
            return accessories;
        }
        [HttpPut]
        public Accessories Update(Accessories accessories)
        {
            _accessoriesService.Update(accessories);
            return accessories;
        }
    }
}
