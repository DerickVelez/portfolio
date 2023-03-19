using GameStore.Service;
using GamingStore.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GamingStoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private static GamesService _gamessService = new GamesService();

        [HttpGet]
        public List<Games> Get()
        {
            return _gamessService.GetGames();

        }
        [HttpPost]
        public Games Add(Games games)
        {
            _gamessService.Add(games);
            return games;
        }
        [HttpPut]
        public Games Update(Games games)
        {
            _gamessService.Update(games);
            return games;
        }
    }
}
