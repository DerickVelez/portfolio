using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore.Data.Entitites;

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
        public List<Order> GetOrder()
        {
            return orderList;
        }

        public void Add(Order order)
        {
            orderList.Add(order);
        }
          
        public void Delete(Order order)
        {
            orderList.Remove(order);
        }

        public void Update(Order order)
        {
            var selectedOrder = orderList.Where(a => a.OrderValue == order.OrderValue).FirstOrDefault();
            selectedOrder = order;
        }

        public Order? FindById(string orderValue)
        {
            return orderList.Where(a => a.OrderValue == orderValue).FirstOrDefault();

        }
           
    }
}
