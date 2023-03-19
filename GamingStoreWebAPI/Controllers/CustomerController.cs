using GameStore.Service;
using GamingStore.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GamingStoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private static CustomerService _customerService { get; set; } = new CustomerService();

        [HttpGet]
        public List<Customer> Get()
        {
            return _customerService.GetCustomer();

        }
        [HttpPost]
        public Customer Add(Customer customer)
        {
            _customerService.Add(customer);
            return customer;
        }
        [HttpPut]
        public Customer Update(Customer customer)
        {
            _customerService.Update(customer);
            return customer;
        }
    }
}
