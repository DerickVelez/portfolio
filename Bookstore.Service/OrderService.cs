using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore.Data.Entitites;
using Dapper;

namespace Bookstore.Service
{
    public class OrderService
    {
        public List<Order> orderList = new List<Order>
        {
            //new Order
            //{
            //    OrderDate = new DateTime(2023,03,10),
            //    OrderValue = "burger"
            //}
        };
        public string connectionString;

        public OrderService(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public bool IsAlreadyExist(string orderValue)
        {
            var order = orderList.Where(a => a.OrderValue == orderValue).FirstOrDefault();
            return order != null;
        }
        public List<Order> GetOrder()
        {

            using var con = new SqlConnection(connectionString);
            con.Open();

            var orders = con.Query<Order>("SELECT * FROM Orders");

            return orders.ToList();
        }

        public Order Add(Order order)
        {
            using var con = new SqlConnection(connectionString);
            con.Open();

            var createdAuthor = con.QuerySingle<Order>("INSERT INTO Orders (OrderDate) OUTPUT INSERTED.OrderValue, INSERTED.OrderDate VALUES (@OrderDate);", order);
            return createdAuthor;
        }

        public Order Delete(Order order) 
        {
            using var con = new SqlConnection(connectionString);
            con.Open();

            var createdAuthor = con.Execute("DELETE FROM Orders WHERE (OrderValue = @OrderValue)", order);
            return order;

        }

        public Order Update(Order order)
        {
            using var con = new SqlConnection(connectionString);
            con.Open();

            var createdAuthor = con.Execute("UPDATE Orders SET OrderDate = @OrderDat WHERE (OrderValue = @OrderValue)", order);
            return order;
        }

        public Order? FindById(string orderValue)
        {
            return orderList.Where(a => a.OrderValue == orderValue).FirstOrDefault();

        }
           
    }
}
