using CarHire_.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarHire.Service
{
    public class VehicleCategoryService
    {
        private List<VehicleCategory> VehicleCategories = new List<VehicleCategory>
        {
            new VehicleCategory
            {
                VehicleCategoryCode = 5456,
                VehicleCategoryDescription = "Sedan",

            }
        };

        public List<VehicleCategory> GetVehicleCategory()
        {
            return VehicleCategories;
        }

        public void Add(VehicleCategory vehicleCategory)
        {
            VehicleCategories.Add(vehicleCategory);
        }

        public void Delete(VehicleCategory vehicleCategory)
        {
            VehicleCategories.Remove(vehicleCategory);
        }

        public void Update(VehicleCategory vehicleCategory)
        {
            var selectedVehicleCategory = VehicleCategories.Where(unit => unit.VehicleCategoryCode == vehicleCategory.VehicleCategoryCode).FirstOrDefault();
            selectedVehicleCategory = vehicleCategory;
        }

        public VehicleCategory? FindById(int vehiclecategoryCode)
        {
            return VehicleCategories.Where(unit => unit.VehicleCategoryCode == vehiclecategoryCode).FirstOrDefault();
        }
    }
}
