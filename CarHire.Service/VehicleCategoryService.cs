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

        public bool IsAlreadyRegistered(int vehicleCategoryCode)
        {
            var vehicleCategory = VehicleCategorieslist.Where(a => a.VehicleCategoryCode == vehicleCategoryCode).FirstOrDefault();
            return vehicleCategory != null;
        }

            public List<VehicleCategory> GetVehicleCategory()
        {
            return VehicleCategorieslist;
        }

        public void Add(VehicleCategory vehicleCategory)
        {
            VehicleCategorieslist.Add(vehicleCategory);
        }

        public List<VehicleCategory> Delete(VehicleCategory vehicleCategory)
        {
            var selectedVehicleCategory = VehicleCategorieslist.Where(
             a => a.VehicleCategoryCode == vehicleCategory.VehicleCategoryCode).FirstOrDefault();
            VehicleCategorieslist.Remove(selectedVehicleCategory);
            return VehicleCategorieslist;
        }

        public void Update(VehicleCategory vehicleCategory)
        {
            Delete(vehicleCategory);
            VehicleCategorieslist.Add(vehicleCategory);
        }

        public VehicleCategory? FindById(int vehiclecategoryCode)
        {
            return VehicleCategorieslist.Where(unit => unit.VehicleCategoryCode == vehiclecategoryCode).FirstOrDefault();
        }
    }
}
