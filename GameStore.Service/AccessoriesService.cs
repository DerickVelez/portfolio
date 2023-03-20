using GamingStore.Data;

namespace GameStore.Service
{
    public class AccessoriesService
    {
        private static List<Accessories> accessoriesList = new List<Accessories>
        {
            new Accessories
            {
                AccessoryName = "cover",
                AccessoryDescription = "color yellow",
                OtherAccessoryDetails = "N/A"
            }
        };

        public List<Accessories> GetAccessories()
        {
            return accessoriesList;
        }

        public void Add(Accessories accessory)
        {
            accessoriesList.Add(accessory);
        }

        public void Delete(Accessories accessory)
        {
            accessoriesList.Remove(accessory);
        }

        public void Update(Accessories accessory)
        {
            var selectedAccessories = accessoriesList.Where(
                a => a.AccessoryName == accessory.AccessoryName).FirstOrDefault();
            accessoriesList.Remove(selectedAccessories);
            accessoriesList.Add(accessory);
        }

        public Accessories? FindById(string accessories)
        {
            return accessoriesList.Where(accessory => accessory.AccessoryName == accessories).FirstOrDefault();
        }
    }
}