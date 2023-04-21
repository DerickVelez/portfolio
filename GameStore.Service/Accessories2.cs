using GamingStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Service
{
    public class Accessories2
    {
        private List<Accessories> accessoriesList = new List<Accessories>
        {
            new Accessories
            {
                AccessoryName =" lenovo",
                AccessoryDescription = "color black",
                OtherAccessoryDetails = " laptop",
            }
        };

        public List<Accessories> GetAccessories()
        {
            return accessoriesList;
        }
        
        public void Add(Accessories accessories)
        {
            accessoriesList.Add(accessories);
        }
            
        public void Delete(Accessories accessories)
        {
            accessoriesList.Remove(accessories);
        }

        public void Update(Accessories accessories)
        {
            var updatedaccessory = accessoriesList.Where(a => a.AccessoryName == accessories.AccessoryName).ToList();
        }

        public Accessories? FindById(string accessories)
        {
            return accessoriesList.Where(a => a.AccessoryName == accessories).FirstOrDefault();
        }
    }
} 
