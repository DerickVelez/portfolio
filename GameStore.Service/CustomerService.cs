using GamingStore.Data.Entities;
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

        private string connectionString;

        public CustomerService(string connectionString)
        {
            this.connectionString = connectionString;
        }
         public bool IsAlreadyRegistered(int customerCode)
        {
            var customer = customerList.Where(x => x.CustomerCode == customerCode).FirstOrDefault();
            return customer != null;
        }
        public List<Customer> GetCustomer()
        {
            return customerList;
        }

        public void Add(Customer customer)
        {
            customerList.Add(customer); 
        }

        public List<Customer> Delete(Customer customer)
        {
            var selectCustomer = customerList.Where(
               a => a.CustomerID == customer.CustomerID).FirstOrDefault();
            customerList.Remove(selectCustomer);
            return customerList;
        }
        public List<Customer> Update(Customer customer)
        {
            Delete(customer);
            customerList.Add(customer);
            return customerList;
            
        }
        
        public Customer? FindById(int customerId)
        {
            return customerList.Where(a => a.CustomerID == customerId).FirstOrDefault();
        }

    }
}
