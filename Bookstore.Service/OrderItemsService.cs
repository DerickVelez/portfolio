using Bookstore.Data.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Service
{
    public class OrderItemsService
    {
        private List<OrderItems> orderitemsList = new List<OrderItems>
        {
            new OrderItems
            {
            ItemNumber = 1,
            ItemAgreedPrice = 54,
            ItemComment = " no comment",
            OrderDate = new DateTime(2023, 03, 29)

            }

        };

        public List<OrderItems> GetOrderItems()
        {
            return orderitemsList;
        }

        public void Add(OrderItems orderitems)
        {
            orderitemsList.Add(orderitems);
        }

        public void Delete(OrderItems orderitems)
        {
            orderitemsList.Remove(orderitems);
        }

        public void Update(OrderItems orderitems)
        {
            var selectedOrderItems = orderitemsList.Where(a => a.ItemNumber == orderitems.ItemNumber).FirstOrDefault();
            selectedOrderItems = orderitems;
        }

        public OrderItems? FindById(int itemnumber)
        {
            return orderitemsList.Where(a => a.ItemNumber == itemnumber).FirstOrDefault();
        }





    }
}
