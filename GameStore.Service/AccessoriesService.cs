﻿using GamingStore.Data.Entities;

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

        private string connectionString;

        public AccessoriesService(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool IsAlreadyRegistered(string accessoryName)
        {
            var accessory = accessoriesList.Where(a =>  a.AccessoryName == accessoryName).FirstOrDefault();
            return accessory != null;
        }


        public List<Accessories> GetAccessories()
        {
            return accessoriesList;
        }

        public void Add(Accessories accessory)
        {
            accessoriesList.Add(accessory);
        }

        public List<Accessories> Delete(Accessories accessory)
        {
            var selectedAccessories = accessoriesList.Where(
         a => a.AccessoryName == accessory.AccessoryName).FirstOrDefault();
            accessoriesList.Remove(selectedAccessories);
            return accessoriesList;
        }

        public List<Accessories> Update(Accessories accessory)
        {
            Delete(accessory);
            accessoriesList.Add(accessory);
            return accessoriesList;
        }

        public Accessories? FindById(string accessories)
        {
            return accessoriesList.Where(accessory => accessory.AccessoryName == accessories).FirstOrDefault();
        }
    }
}