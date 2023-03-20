using GamingStore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Service
{
    public class CustomerService
    {
        public List<Customer> customerList = new List<Customer>
        {
            new Customer
            {
                CustomerCode = 54,
                CustomerID = 155,
                CustomerName = "Derick",
                CustomerOtherDetails = "no comment",

            },
            new Customer
            {
                CustomerCode = 7454,
                CustomerID = 4554,
                CustomerOtherDetails = "sdhfl",

            }
        };
        public List<Customer> GetCustomer()
        {
            return customerList;
        }

        public void Add(Customer customer)
        {
            customerList.Add(customer); 
        }

        public void Delete(Customer customer)
        {
            customerList.Remove(customer); 
        }
        public void Update(Customer customer)
        {

            var selectCustomer = customerList.Where(
                a => a.CustomerID == customer.CustomerID).FirstOrDefault();
            customerList.Remove(selectCustomer);
            customerList.Add(customer);
            
        }
        
        public Customer? FindById(int customerId)
        {
            return customerList.Where(a => a.CustomerID == customerId).FirstOrDefault();
        }

    }
}
