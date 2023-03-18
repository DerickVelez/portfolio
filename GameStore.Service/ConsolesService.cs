using GamingStore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Service
{
    public class ConsolesService
    {
        private List<Consoles> consolesList = new List<Consoles>
        {
            new Consoles
            {
                DriveType = "abc",
                OtherConsoleDetails = "color yellow",
                Size = 232,
            }
        };

        public List<Consoles> Get()
        {
            return consolesList;
        }

        public void Add(Consoles consoles)
        {
            consolesList.Add(consoles);
        }

        public void Delete(Consoles console)
        {
            consolesList.Remove(console);
        }

        public void Update(Consoles console)
        {
            var selectedconsole = consolesList.Where(a => a.DriveType == console.DriveType).FirstOrDefault();
            selectedconsole = console;
        }

        public Consoles? FindById(string console)
        {
            return consolesList.Where(a => a.DriveType == console).FirstOrDefault();
        }
    }

} 
