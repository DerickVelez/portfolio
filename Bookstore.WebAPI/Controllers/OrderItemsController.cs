using Bookstore.Data.Entitites;
using Bookstore.Service;
using Microsoft.AspNetCore.Http;
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
            _OrderItemsService.Add(orderitems);
            return orderitems;
        }

        [HttpPut]

        public OrderItems Update(OrderItems orderitems)
        {
            _OrderItemsService.Update(orderitems);
            return orderitems;
        }



    }

}
