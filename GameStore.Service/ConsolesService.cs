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
            var selectedconsole = consolesList.Where(
           a => a.DriveType == console.DriveType).FirstOrDefault();
            consolesList.Remove(selectedconsole);
            return consolesList;
        }

        public List<Consoles> Update(Consoles console)
        {
            Delete(console);
            consolesList.Add(console);
            return consolesList;
        }

        public Consoles? FindById(string console)
        {
            return consolesList.Where(a => a.DriveType == console).FirstOrDefault();
        }
    }

} 
