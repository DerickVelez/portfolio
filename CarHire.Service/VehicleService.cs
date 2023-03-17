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
        private List<Vehicle> Vehicles = new List<Vehicle>
        {
            new Vehicle
            {
                RegNumber = 999,
                CurrentMileage = 45656,
                DailyMotDue = 6565,
                EngineSize = 44,

            }
        };

        public List<Vehicle> GetVehicles()
        {
            return Vehicles;
        }

        public void Add(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);  
        }

        public void Delete(Vehicle vehicle)
        {
            Vehicles.Remove(vehicle);
        }

        public void Update(Vehicle vehicle)
        {
            var selectedVehicle = Vehicles.Where(unit => unit.RegNumber == vehicle.RegNumber).FirstOrDefault();
            selectedVehicle = vehicle;
        }

        public Vehicle? FindById(int regNumber)
        {
            return Vehicles.Where(unit =>unit.RegNumber == regNumber).FirstOrDefault();  
        }
    }
}
