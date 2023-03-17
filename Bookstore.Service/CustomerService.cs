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

        public void Delete(Customer customer)
        {
            customerList.Remove(customer);
        }

        public void Update(Customer UpdatedCustomer)
        {
            
                var selectCustomer = customerList.Where(customer => customer.CustomerID == UpdatedCustomer.CustomerID).FirstOrDefault();
                selectCustomer = UpdatedCustomer;
        }

        public Customer? FindById(int customerId)
        {
            return customerList.Where(a => a.CustomerID == customerId).FirstOrDefault();
        }


    }


}
    
