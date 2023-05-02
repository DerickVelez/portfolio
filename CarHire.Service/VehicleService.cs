using CarHire_.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarHire.Service
{
    public class VehicleService
    {
        private List<Vehicle> Vehicleslist = new List<Vehicle>
        {
            new Vehicle
            {
                RegNumber = 999,
                CurrentMileage = 45656,
                DailyMotDue = 6565,
                EngineSize = 44,

            }
        };
        public bool IsAlreadyRegistered(int regNumber)
        {
            var vehicle = Vehicleslist.Where(a => a.RegNumber == regNumber).FirstOrDefault();
            return vehicle != null;
        }


            public List<Vehicle> GetVehicles()
        {
            return Vehicleslist;
        }

        public void Add(Vehicle vehicle)
        {
            Vehicleslist.Add(vehicle);  
        }

        public List<Vehicle> Delete(Vehicle vehicle)
        {
            var selectedVehicle = Vehicleslist.Where(
                          a => a.RegNumber == vehicle.RegNumber).FirstOrDefault();
            Vehicleslist.Remove(selectedVehicle); 
            return Vehicleslist;
        }

        public void Update(Vehicle vehicle)
        {
            Delete(vehicle);
            Vehicleslist.Add(vehicle);
        }

        public Vehicle? FindById(int regNumber)
        {
            return Vehicleslist.Where(unit =>unit.RegNumber == regNumber).FirstOrDefault();  
        }
    }
}
