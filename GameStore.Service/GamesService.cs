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

        public List<Games> GetGames()
        {
            return gamesserviceList;
        }

        public void Add(Games game)
        {
            gamesserviceList.Add(game);
        }

        public List<Games> Delete(Games game)
        {
           gamesserviceList = gamesserviceList.Where(a => a.GameName != game.GameName).ToList();
            return gamesserviceList;
        }

        public void Update(Games game)
        {
            var selectedCustomerPurchase = gamesserviceList.Where(
               a => a.GameName == game.GameName).FirstOrDefault();
            gamesserviceList.Remove(selectedCustomerPurchase);
            gamesserviceList.Add(game);
        }

        public Games? FindById(string gamename)
        {
            return gamesserviceList.Where(a => a.GameName == gamename).FirstOrDefault();
        }
    }
}
