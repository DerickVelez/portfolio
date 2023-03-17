using CarHire_.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarHire.Service
{
    public class ManufacturerService
    {
        private List<Manufacturer> Manufacturers = new List<Manufacturer>
        { 
            new Manufacturer
            {
                ManufacturerCode = 4561,
                ManufacturerDetails = "Made in Japan",
                ManufacturerName = "Toyota",
            }
            };
        public List<Manufacturer> GetManufacturer()
        {
            return Manufacturers;
        }

        public void Add(Manufacturer manufacturer)
        {
            Manufacturers.Add(manufacturer);
        }

        public void Delete(Manufacturer manufacturer)
        {
            Manufacturers.Remove(manufacturer);
        }

        public void Update(Manufacturer manufacturer)
        {
            var selectedManufacturer = Manufacturers.Where(unit => unit.ManufacturerCode == manufacturer.ManufacturerCode).FirstOrDefault();
            selectedManufacturer = manufacturer;
        }

        public Manufacturer? FindById(int ManufacturerCode)
        {
            return Manufacturers.Where(unit => unit.ManufacturerCode == ManufacturerCode).FirstOrDefault();

        }
    }
}
