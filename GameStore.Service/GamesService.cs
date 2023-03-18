using GamingStore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Service
{
    public class GamesService
    {
        private List<Games> gamesserviceList = new List<Games>
        {
            new Games
            {
                GameName = "Ml",
                MemoryRequired = 446,
                OtherGameDetails = "dfg",
                NumberOfPlayers = 1,

            }
        };

        public List<Games> Get()
        {
            return gamesserviceList;
        }

        public void Add(Games games)
        {
            gamesserviceList.Add(games);
        }

        public void Delete(Games games)
        {
            gamesserviceList.Remove(games);
        }

        public void Update(Games games)
        {
            var selectedCustomerPurchase = gamesserviceList.Where(a => a.GameName == games.GameName).FirstOrDefault();
        }

        public Games? FindById(string gamename)
        {
            return gamesserviceList.Where(a => a.GameName == gamename).FirstOrDefault();
        }
    }
}
