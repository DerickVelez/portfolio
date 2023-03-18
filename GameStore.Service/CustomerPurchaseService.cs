using GamingStore.Data;
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
            new CustomerPurchase
            {
                PurchaseID = 484,
                DateOfPurchase = new DateTime(2022, 5,6),
                OtherPurchaseDetails = "kdhf",

            }
        };

        public List<CustomerPurchase> Get()
        {
            return customerpurchaseList;
        }

        public void Add(CustomerPurchase customerPurchase)
        {
            customerpurchaseList.Add(customerPurchase);
        }

        public void Delete(CustomerPurchase customerpurchase)
        {
            customerpurchaseList.Remove(customerpurchase);
        }

        public void Update(CustomerPurchase customerpurchase)
        {
            var selectedCustomerPurchase = customerpurchaseList.Where(a => a.PurchaseID == customerpurchase.PurchaseID).FirstOrDefault();
        }

        public CustomerPurchase? FindById(int purchaseId)
        {
            return customerpurchaseList.Where(a => a.PurchaseID == purchaseId).FirstOrDefault();
        }
    }
}
