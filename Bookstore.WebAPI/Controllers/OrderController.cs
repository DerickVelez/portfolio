using Bookstore.Data.Entitites;
using Bookstore.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private static OrderService _OrderService { get; set; } = new OrderService();

        [HttpGet]
        public List<Order> Get()
        {
         
            return _OrderService.GetOrder();
        }

        [HttpPost]
        public Order Add(Order order)
        {
            _OrderService.Add(order);
            return order;
        }
        [HttpPut]
        public Order Update(Order order)
        {
            _OrderService.Update(order);
            return order;
        }
    }
}
