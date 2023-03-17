using CarHire_.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarHire.Service
{
    public class CustomerService
    {
        private List<Customer> Customers = new List<Customer>
        {
            new Customer
            {
                CustomerID = 6565,
                CustomerName = "JOBERT",
                CustomerDetails = "odlh",
                Country = " Ph",
                Town = "Calaba",
                Gender = "Male",
                AddressLine1 = "djfldks",
                AddressLine2 = "hfkdjh",
                AddressLine3 = " skdjafh",
                County = "dshkdh",
                EmailAddress = "@gmail.com",
                PhoneNumber = 4656464,

            }
        };

        public List<Customer> GetCustomers()
        {
            return Customers;
        }

        public void Add(Customer customer)
        {
            Customers.Add(customer);
        }
        public void Delete(Customer customer)
        {
            Customers.Remove(customer);
        }

        public void Update(Customer customer)
        {
            var selectedCustomer = Customers.Where(unit => unit.CustomerID == customer.CustomerID).FirstOrDefault();
            selectedCustomer = customer;
        }

        public Customer? FindById(int CustomerId)

        {
            return Customers.Where(unit => unit.CustomerID == CustomerId).FirstOrDefault();
        }
    }
}
