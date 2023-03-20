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
        private List<Manufacturer> Manufacturerslist = new List<Manufacturer>
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
            return Manufacturerslist;
        }

        public void Add(Manufacturer manufacturer)
        {
            Manufacturerslist.Add(manufacturer);
        }

        public void Delete(Manufacturer manufacturer)
        {
            Manufacturerslist.Remove(manufacturer);
        }

        public void Update(Manufacturer manufacturer)
        {
            var selectedManufacturer = Manufacturerslist.Where(
                a => a.ManufacturerCode == manufacturer.ManufacturerCode).FirstOrDefault();
            Manufacturerslist.Remove(selectedManufacturer);
            Manufacturerslist.Add(manufacturer);
        }

        public Manufacturer? FindById(int ManufacturerCode)
        {
            return Manufacturerslist.Where(unit => unit.ManufacturerCode == ManufacturerCode).FirstOrDefault();

        }
    }
}
