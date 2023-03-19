using GameStore.Service;
using GamingStore.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GamingStoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerPurchaseController : ControllerBase
    {
        private static CustomerPurchaseService _customerpurchaseService { get; set; } = new CustomerPurchaseService();

        [HttpGet]
        public List<CustomerPurchase> Get()
        {
            return _customerpurchaseService.GetCustomerPurchase();

        }
        [HttpPost]
        public CustomerPurchase Add(CustomerPurchase customerpurchase)
        {
            _customerpurchaseService.Add(customerpurchase);
            return customerpurchase;
        }
        [HttpPut]
        public CustomerPurchase Update(CustomerPurchase customerpurchase)
        {
            _customerpurchaseService.Update(customerpurchase);
            return customerpurchase;
        }
    }
}
