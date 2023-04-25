using GamingStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Service
{
    public class CustomerPurchaseService
    {
        private List<CustomerPurchase> customerpurchaseList = new List<CustomerPurchase>
        {
            //new CustomerPurchase
            //{
            //    PurchaseID = 484,
            //    DateOfPurchase = new DateTime(2022, 5,6),
            //    OtherPurchaseDetails = "kdhf",

            //}
        };
        private string connectionString;

        public CustomerPurchaseService(string connectionString)
        {
            this.connectionString = connectionString;
        }

         public bool IsAlreadyRegistered(int purchaseID)
        {
            var customerpurchase = customerpurchaseList.Where(a => a.PurchaseID == purchaseID).FirstOrDefault();
            return customerpurchase != null;
        }

        public List<CustomerPurchase> GetCustomerPurchase()
        {
            return customerpurchaseList;
        }

        public void Add(CustomerPurchase customerPurchase)
        {
            customerpurchaseList.Add(customerPurchase);
        }

        public List<CustomerPurchase> Delete(CustomerPurchase customerpurchase)
        {
            customerpurchaseList = customerpurchaseList.Where(a => a.PurchaseID != customerpurchase.PurchaseID).ToList();
            return customerpurchaseList;
        }

        public void Update(CustomerPurchase customerpurchase)
        {
            var selectedCustomerPurchase = customerpurchaseList.Where(
                a => a.PurchaseID == customerpurchase.PurchaseID).FirstOrDefault();
            customerpurchaseList.Remove(selectedCustomerPurchase);
            customerpurchaseList.Add(customerpurchase);
        }

        public CustomerPurchase? FindById(int purchaseId)
        {
            return customerpurchaseList.Where(a => a.PurchaseID == purchaseId).FirstOrDefault();
        }
    }
}
