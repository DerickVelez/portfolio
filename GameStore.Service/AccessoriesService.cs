using GamingStore.Data;

namespace GameStore.Service
{
    public class AccessoriesService
    {
        private List<Accessories> accessoriesList = new List<Accessories>
        {
            new Accessories
            {
                AccessoryName = "cover",
                AccessoryDescription = "color yellow",
                OtherAccessoryDetails = "N/A"
            }
        };

        public List<Accessories> Get()
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
            var selectedAccessories = accessoriesList.Where(accessory => accessory.AccessoryName == accessories.AccessoryName).FirstOrDefault();
            selectedAccessories = accessories;
        }

        public Accessories? FindById(string accessories)
        {
            return accessoriesList.Where(accessory => accessory.AccessoryName == accessories).FirstOrDefault();
        }
    }
}