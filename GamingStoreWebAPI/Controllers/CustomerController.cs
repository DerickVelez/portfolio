using GameStore.Service;
using GamingStore.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GamingStoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private static CustomerService _customerService;

        public CustomerController(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DerickServer");
            _customerService = new CustomerService(connectionString);
        }

        [HttpGet]
        public List<Customer> Get()
        {
            return _customerService.GetCustomer();

        }
        [HttpPost]
        public Customer Add(Customer customer)
        {
            bool alreadyexist = _customerService.IsAlreadyRegistered(customer.CustomerID);
            if (alreadyexist)
                return null;

            _customerService.Add(customer);
            return customer;
        }
        [HttpPut]
        public Customer Update(Customer customer)
        {
            _customerService.Update(customer);
            return customer;
        }
        [HttpDelete]

        public Customer Delete(Customer customer)
        {
            _customerService.Delete(customer);
            return customer;
        }
    }
}
