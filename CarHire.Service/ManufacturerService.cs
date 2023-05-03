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
        public bool IsAlreadyRegistered(int manufacturername)
        {
            var manufacturer = Manufacturerslist.Where(a => a.ManufacturerCode == manufacturername).FirstOrDefault();
            return manufacturer != null;


        }
        public List<Manufacturer> GetManufacturer()
        {
            return Manufacturerslist;
        }

        public void Add(Manufacturer manufacturer)
        {
            Manufacturerslist.Add(manufacturer);
        }

        public List<Manufacturer> Delete(Manufacturer manufacturer)
        {
            var selectedManufacturer = Manufacturerslist.Where(
             a => a.ManufacturerCode == manufacturer.ManufacturerCode).FirstOrDefault();
            Manufacturerslist.Remove(selectedManufacturer); 
            return Manufacturerslist;
        }

        public void Update(Manufacturer manufacturer)
        {
            Delete(manufacturer);
            Manufacturerslist.Add(manufacturer);
        }

        public Manufacturer? FindById(int ManufacturerCode)
        {
            return Manufacturerslist.Where(unit => unit.ManufacturerCode == ManufacturerCode).FirstOrDefault();

        }
    }
}
