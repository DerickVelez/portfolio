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
        private List<Customer> Customerslist = new List<Customer>
        {
            new Customer
            {
                CustomerID = 6565,
                CustomerName = "JOBERT",
                CustomerDetails = "odlh",
                Country = " Ph",
                Town = "Calamba",
                Gender = "Male",
                AddressLine1 = "djfldks",
                AddressLine2 = "hfkdjh",
                AddressLine3 = " skdjafh",
                County = "dshkdh",
                EmailAddress = "@gmail.com",
                PhoneNumber = 4656464,

            }
        };
        public bool IsAlreadyRegistered(int customerID)
        {
            var customer = Customerslist.Where(a => a.CustomerID == customerID).FirstOrDefault();
            return customer != null;
        }

        public List<Customer> GetCustomers()
        {
            return Customerslist;
        }

        public void Add(Customer customer)
        {
            Customerslist.Add(customer);
        }
        public List<Customer> Delete(Customer customer)

        {
            var selectedCustomer = Customerslist.Where(
               a => a.CustomerID == customer.CustomerID).FirstOrDefault();
            Customerslist.Remove(selectedCustomer);
            return Customerslist;
        }

        public void Update(Customer customer)
        {
            Delete(customer);
            Customerslist.Add(customer);
        }

        public Customer? FindById(int CustomerId)
        {
            return Customerslist.Where(unit => unit.CustomerID == CustomerId).FirstOrDefault();
        }
    }
}
