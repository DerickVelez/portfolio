using GameStore.Service;
using GamingStore.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GamingStoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsolesController : ControllerBase
    {
        private static ConsolesService _consolesServiceService { get; set; } = new ConsolesService();

        [HttpGet]
        public List<Consoles> Get()
        {
            return _consolesServiceService.GetConsoles();

        }
        [HttpPost]
        public Consoles Add(Consoles consoles)
        {
            _consolesServiceService.Add(consoles);
            return consoles;
        }
        [HttpPut]
        public Consoles Update(Consoles consoles)
        {
            _consolesServiceService.Update(consoles);
            return consoles;
        }
    }
}
