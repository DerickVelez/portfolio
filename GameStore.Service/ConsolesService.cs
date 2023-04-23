using GamingStore.Data.Entities;
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
            //new Consoles
            //{
            //    DriveType = "abc",
            //    OtherConsoleDetails = "color yellow",
            //    Size = 232,
            //}
        };
         private string connectionString;

        public ConsolesService(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool IsAlresdyRegistered(string drivetype)
        {
            var condoles = consolesList.Where(c => c.DriveType == drivetype).FirstOrDefault();
            return condoles != null;
        }

        public List<Consoles> GetConsoles()
        {
            return consolesList;
        }

        public void Add(Consoles consoles)
        {
            consolesList.Add(consoles);
        }

        public List<Consoles> Delete(Consoles console)
        {
            consolesList = consolesList.Where(a => a.DriveType != console.DriveType).ToList();
            return consolesList;
        }

        public void Update(Consoles console)
        {
            var selectedconsole = consolesList.Where(
                a => a.DriveType == console.DriveType).FirstOrDefault();
            consolesList.Remove(selectedconsole);
            consolesList.Add(console);
        }

        public Consoles? FindById(string console)
        {
            return consolesList.Where(a => a.DriveType == console).FirstOrDefault();
        }
    }

} 
