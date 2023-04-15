using GamingStore.Data.Entities;
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

        public string connectionString;

        public CustomerOrderService(string connectionString)
        {
        this.connectionString = connectionString;
        }
        public bool IsAlreadyRegistered(int orderID)
        {
            var customerorder = customerorderList.Where(a => a.OrderID == orderID).FirstOrDefault();
            return customerorder != null;
        }

        public List<CustomerOrders> GetCustomerOrders()
        {
            return customerorderList;
        }

        public void Add(CustomerOrders customerOrder)
        {
            customerorderList.Add(customerOrder);
        }

        public List<CustomerOrders> Delete(CustomerOrders customerOrder)
        {
            customerorderList = customerorderList.Where(a => a.OrderID != customerOrder.OrderID).ToList();
            return customerorderList;
        }

        public void Update(CustomerOrders customerOrder)
        {
            var selectedCustomerOrder = customerorderList.Where(
                a => a.OrderID == customerOrder.OrderID).FirstOrDefault();
            customerorderList.Remove(selectedCustomerOrder);
            customerorderList.Add(customerOrder);
        }

        public CustomerOrders? FindById(int orderID)
        {
            return customerorderList.Where(a => a.OrderID == orderID).FirstOrDefault();

        }


    }

}
