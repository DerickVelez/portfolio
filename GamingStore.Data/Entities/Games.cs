using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingStore.Data.Entities
{
    public class Games
    {
        public string GameName { get; set; }

        public int MemoryRequired { get; set; }
        public int NumberOfPlayers { get; set; }

        public string OtherGameDetails { get; set; }

    }
}
