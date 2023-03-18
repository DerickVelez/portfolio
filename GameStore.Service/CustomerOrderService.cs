using GamingStore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Service
{
    public class CustomerOrderService
    {
        private List<CustomerOrders> customerorderList = new List<CustomerOrders>
        {
            new CustomerOrders
            {
                OrderID = 5454,
                DateOfOrder = new DateTime(2023,05,2),
                OtherOrderDetails = "sdjhfk"
            }
        };

        public List<CustomerOrders> Get()
        {
            return customerorderList;
        }

        public void Add(CustomerOrders customerOrders)
        {
            customerorderList.Add(customerOrders);
        }

        public void Delete(CustomerOrders customerOrders)
        {
            customerorderList.Remove(customerOrders);
        }

        public void Update(CustomerOrders customerOrders)
        {
            var selectedCustomerOrder = customerorderList.Where(a => a.OrderID == customerOrders.OrderID).FirstOrDefault();
            selectedCustomerOrder = customerOrders;
        }

        public CustomerOrders? FindById(int orderID)
        {
            return customerorderList.Where(a => a.OrderID == orderID).FirstOrDefault();

        }


    }

}
