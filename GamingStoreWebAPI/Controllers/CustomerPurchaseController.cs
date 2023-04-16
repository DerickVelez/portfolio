using GameStore.Service;
using GamingStore.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GamingStoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerPurchaseController : ControllerBase
    {
        private static CustomerPurchaseService _customerpurchaseService;

        public CustomerPurchaseController(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DerickServer");
            _customerpurchaseService = new CustomerPurchaseService(connectionString);
        }

        [HttpGet]
        public List<CustomerPurchase> Get()
        {
            return _customerpurchaseService.GetCustomerPurchase();

        }
        [HttpPost]
        public CustomerPurchase Add(CustomerPurchase customerpurchase)
        {
            bool alreadyexist = _customerpurchaseService.IsAlreadyRegistered(customerpurchase.PurchaseID);
            if (alreadyexist)
                return null;

            _customerpurchaseService.Add(customerpurchase);
            return customerpurchase;
        }
        [HttpPut]
        public CustomerPurchase Update(CustomerPurchase customerpurchase)
        {
            _customerpurchaseService.Update(customerpurchase);
            return customerpurchase;
        }
        [HttpDelete]

        public CustomerPurchase Delete(CustomerPurchase customerpurchase)
        {
            _customerpurchaseService.Delete(customerpurchase);
            return customerpurchase;
        }

    }
}
