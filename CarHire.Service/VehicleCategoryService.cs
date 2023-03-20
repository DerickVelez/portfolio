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
        private List<VehicleCategory> VehicleCategorieslist = new List<VehicleCategory>
        {
            new VehicleCategory
            {
                VehicleCategoryCode = 5456,
                VehicleCategoryDescription = "Sedan",

            }
        };

        public List<VehicleCategory> GetVehicleCategory()
        {
            return VehicleCategorieslist;
        }

        public void Add(VehicleCategory vehicleCategory)
        {
            VehicleCategorieslist.Add(vehicleCategory);
        }

        public void Delete(VehicleCategory vehicleCategory)
        {
            VehicleCategorieslist.Remove(vehicleCategory);
        }

        public void Update(VehicleCategory vehicleCategory)
        {
            var selectedVehicleCategory = VehicleCategorieslist.Where(
                a => a.VehicleCategoryCode == vehicleCategory.VehicleCategoryCode).FirstOrDefault();
            VehicleCategorieslist.Remove(selectedVehicleCategory);
            VehicleCategorieslist.Add(vehicleCategory);
        }

        public VehicleCategory? FindById(int vehiclecategoryCode)
        {
            return VehicleCategorieslist.Where(unit => unit.VehicleCategoryCode == vehiclecategoryCode).FirstOrDefault();
        }
    }
}
