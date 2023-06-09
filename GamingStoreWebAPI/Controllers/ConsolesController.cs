﻿using GameStore.Service;
using GamingStore.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GamingStoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsolesController : ControllerBase
    {
        private static ConsolesService _consolesServiceService;

        public ConsolesController(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DerickServer");
            _consolesServiceService = new ConsolesService(connectionString);
        }

        [HttpGet]
        public List<Consoles> Get()
        {
            return _consolesServiceService.GetConsoles();

        }
        [HttpPost]
        public Consoles Add(Consoles consoles)
        {
            bool alreadyexist = _consolesServiceService.IsAlresdyRegistered(consoles.DriveType);
            if (alreadyexist)
                return null;

            _consolesServiceService.Add(consoles);
            return consoles;
        }
        [HttpPut]
        public Consoles Update(Consoles consoles)
        {
            _consolesServiceService.Update(consoles);
            return consoles;
        }
        [HttpDelete]
        public Consoles Delete(Consoles consoles)
        {
            _consolesServiceService.Delete(consoles);
            return consoles;
        }
    }
}
