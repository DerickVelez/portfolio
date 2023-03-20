﻿using CarHire_.Data;
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
            return Customerslist;
        }

        public void Add(Customer customer)
        {
            Customerslist.Add(customer);
        }
        public void Delete(Customer customer)
        {
            Customerslist.Remove(customer);
        }

        public void Update(Customer customer)
        {
            var selectedCustomer = Customerslist.Where(
                a => a.CustomerID == customer.CustomerID).FirstOrDefault();
            Customerslist.Remove(selectedCustomer);
            Customerslist.Add(customer);
        }

        public Customer? FindById(int CustomerId)

        {
            return Customerslist.Where(unit => unit.CustomerID == CustomerId).FirstOrDefault();
        }
    }
}
