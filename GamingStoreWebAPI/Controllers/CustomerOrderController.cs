using GameStore.Service;
using GamingStore.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GamingStoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerOrderController : ControllerBase
    {
        private static CustomerOrderService _productsService { get; set; } = new CustomerOrderService();

        [HttpGet]
        public List<CustomerOrders> Get()
        {
            return _productsService.GetCustomerOrders();

        }
        [HttpPost]
        public CustomerOrders Add(CustomerOrders customerorder)
        {
            bool alreadyexist = _productsService.IsAlreadyRegistered(customerorder.OrderID);
            if (alreadyexist)
                return null;

            _productsService.Add(customerorder);
            return customerorder;
        }
        [HttpPut]
        public CustomerOrders Update(CustomerOrders customerorder)
        {
            _productsService.Update(customerorder);
            return customerorder;
        }
        [HttpDelete]
        public CustomerOrders  Delete(CustomerOrders customerorder)
        {
            _productsService.Delete(customerorder);
            return customerorder;
        }

    }
}
