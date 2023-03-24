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
            new Order
            {
                OrderDate = new DateTime(2023,03,10),
                OrderValue = "burger"
            }
        };

        public bool IsAlreadyExist(string orderValue)
        {
            var order = orderList.Where(a => a.OrderValue == orderValue).FirstOrDefault();
            return order != null;
        }
        public List<Order> GetOrder()
        {
            var cs = @"Server=DESKTOP-F3KVDMV\MSSQLSERVER01;Database=Bookstore;Trusted_Connection=True;";

            using var con = new SqlConnection(cs);
            con.Open();

            var orders = con.Query<Order>("SELECT * FROM Orders");

            return orders.ToList();
        }

        public void Add(Order order)
        {
            orderList.Add(order);
        }
          
        public List<Order> Delete(Order order)
        {
           orderList = orderList.Where(a => a.OrderValue != order.OrderValue).ToList();
            return orderList;
        }

        public void Update(Order order)
        {
            var selectedOrder = orderList.Where(
                a => a.OrderValue == order.OrderValue).FirstOrDefault();
            orderList.Remove(selectedOrder);
            orderList.Add(order);
        }

        public Order? FindById(string orderValue)
        {
            return orderList.Where(a => a.OrderValue == orderValue).FirstOrDefault();

        }
           
    }
}
