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
        public string connectionString = @"Server=DESKTOP-F3KVDMV\MSSQLSERVER01;Database=Bookstore;Trusted_Connection=True;";
        public bool IsAlreadyExist(int customerID)
        {
            var customer = customerList.Where(a => a.CustomerID == customerID).FirstOrDefault();
            return customer != null;
        }

        public List<Customer> GetCustomer()
        {

            using var con = new SqlConnection(connectionString);
            con.Open();

            var customers = con.Query<Customer>("SELECT * FROM Customers");

            return customers.ToList();
        }

        public Customer Add(Customer customer)
        {
            using var con = new SqlConnection(connectionString);
            con.Open();

            var createdAuthor = con.QuerySingle<Customer>("INSERT INTO Customers (CustomerCode,CustomerName,CustomerAddress,CustomerPhone, CustomerEmail) OUTPUT INSERTED.CustomerID, INSERTED.CustomerCode, INSERTED.CustomerName, INSERTED.CustomerAddress, INSERTED.CustomerPhone, INSERTED.CustomerEmail VALUES (@CustomerCode,@CustomerName,@CustomerAddress,@CustomerPhone, @CustomerEmail);", customer);
            return createdAuthor;
        }

        public Customer Delete(Customer customer)
        {
            using var con = new SqlConnection(connectionString);
            con.Open();

            var createdAuthor = con.Execute("DELETE FROM Customers WHERE (CustomerID = @CustomerID)",customer);
            return customer;
        }

        public Customer Update(Customer customer)
        {

            using var con = new SqlConnection(connectionString);
            con.Open();

            var createdAuthor = con.Execute("UPDATE Customers SET CustomerName = @CustomerName, CustomerAddress = @CustomerAddress, CustomerPhone = @CustomerPhone, CustomerEmail =@CustomerEmail WHERE (CustomerID = @CustomerID)", customer);
            return customer;
        }

        public Customer? FindById(int customerId)
        {
            return customerList.Where(a => a.CustomerID == customerId).FirstOrDefault();
        }
    }
}
    
