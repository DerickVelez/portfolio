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

        public bool IsAlreadyExist(int itemNumber)
        {
            var orderItems = orderitemsList.Where(a => a.ItemNumber == itemNumber).FirstOrDefault();
            return orderItems != null;
        }

        public List<OrderItems> GetOrderItems()
        {
            return orderitemsList;
        }

        public void Add(OrderItems orderitem)
        {
            orderitemsList.Add(orderitem);
        }

        public List<OrderItems> Delete(OrderItems orderitem)
        {
            orderitemsList = orderitemsList.Where(a => a.ItemNumber == orderitem.ItemNumber).ToList();
            return orderitemsList;
        }

        public void Update(OrderItems orderitem)
        {
            var selectedOrderItems = orderitemsList.Where(
                a => a.ItemNumber == orderitem.ItemNumber).FirstOrDefault();
            orderitemsList.Remove(selectedOrderItems);
            orderitemsList.Add(orderitem);
        }

        public OrderItems? FindById(int itemnumber)
        {
            return orderitemsList.Where(a => a.ItemNumber == itemnumber).FirstOrDefault();
        }

    }
}
