using Bookstore.Data.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Service
{
    public class CustomerService
    {
        private List<Customer> customerList = new List<Customer>()
        {
            new Customer
            {
                CustomerID = 1,
                CustomerCode = 1,
                CustomerName = "Alvin Almodal",
                CustomerAddress = "Binan,Laguna",
                CustomerPhone = 092346541,
                CustomerEmail = "sahashdl@gmail.com",
            },

        };


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
            customerList = customerList.Where(a => a.CustomerID != customer.CustomerID).ToList();
            return customerList;
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
    
