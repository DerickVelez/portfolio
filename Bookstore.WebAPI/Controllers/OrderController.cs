﻿using Bookstore.Data.Entitites;
using Bookstore.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private static OrderService _OrderService;

        public OrderController(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DerickServer");
            _OrderService = new OrderService(connectionString);
        }

        [HttpGet]
        public List<Order> Get()
        {
            return _OrderService.GetOrder();
        }

        [HttpPost]
        public Order Add(Order order)
        {
            bool alreadyexist = _OrderService.IsAlreadyExist(order.OrderValue);
            if (alreadyexist)
                return null;
            _OrderService.Add(order);
            return order;
        }
        [HttpPut]
        public Order Update(Order order)
        {
            _OrderService.Update(order);
            return order;
        }
        [HttpDelete]

        public Order Delete(Order order)
        {
            _OrderService.Delete(order);
            return order;
        }
    }
}
