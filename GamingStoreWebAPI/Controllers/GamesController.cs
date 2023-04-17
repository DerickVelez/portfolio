using GameStore.Service;
using GamingStore.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GamingStoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private static GamesService _gamesService;

        public GamesController(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DerickServer");
            _gamesService = new GamesService(connectionString);
        }

        [HttpGet]
        public List<Games> Get()
        {
            return _gamesService.GetGames();

        }
        [HttpPost]
        public Games Add(Games games)
        {
            bool alreadyexist = _gamesService.IsAlreadyRegistered(games.GameName);
            if (alreadyexist)
                return null;

            _gamesService.Add(games);
            return games;
        }
        [HttpPut]
        public Games Update(Games games)
        {
            _gamesService.Update(games);
            return games;
        }

        [HttpDelete]

        public Games Delete(Games games)
        {
            _gamesService.Delete(games);
            return games;
        }
    }
}
