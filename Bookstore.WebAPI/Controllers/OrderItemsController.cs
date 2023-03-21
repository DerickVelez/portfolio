using Bookstore.Data.Entitites;
using Bookstore.Service;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemsController : ControllerBase
    {
        private static OrderItemsService _OrderItemsService { get; set; } = new OrderItemsService();


        [HttpGet]
        public List<OrderItems> Get()
        {
            
            return _OrderItemsService.GetOrderItems();
        }
        [HttpPost]

        public OrderItems Add(OrderItems orderitems)
        {
            bool alreadyexist = _OrderItemsService.IsAlreadyExist(orderitems.ItemNumber);
            if (alreadyexist)
                return null;
            _OrderItemsService.Add(orderitems);
            return orderitems;
        }

        [HttpPut]

        public OrderItems Update(OrderItems orderitems)
        {
            _OrderItemsService.Update(orderitems);
            return orderitems;
        }

        [HttpDelete]
            
            public OrderItems Delete(OrderItems order)
        {
            _OrderItemsService.Delete(order);
            return order;
        }
    }

}
