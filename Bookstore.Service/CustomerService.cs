using Bookstore.Data.Entitites;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        public bool IsAlreadyExist(int customerID)
        {
            var customer = customerList.Where(a => a.CustomerID == customerID).FirstOrDefault();
            return customer != null;
        }

        public List<Customer> GetCustomer()
        {
            var cs = @"Server=DESKTOP-F3KVDMV\MSSQLSERVER01;Database=Bookstore;Trusted_Connection=True;";

            using var con = new SqlConnection(cs);
            con.Open();

            var customers = con.Query<Customer>("SELECT * FROM Customers");

            return customers.ToList();
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
    
