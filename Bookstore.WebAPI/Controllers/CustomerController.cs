using Bookstore.Data.Entitites;
using Bookstore.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private static CustomerService _CustomerService{ get; set; } = new CustomerService();

        [HttpGet]
        public List<Customer> Get()
        {
            return _CustomerService.GetCustomer();
        }

        [HttpPost]

        public Customer Add(Customer customer)
        {
            bool alreadyExist = _CustomerService.IsAlreadyExist(customer.CustomerID);
            if (alreadyExist)
                return null;
            _CustomerService.Add(customer);
            return customer;
        }

        [HttpPut]
        public Customer Update(Customer customer)
        {
            _CustomerService.Update(customer);
            return customer;
        }
        [HttpDelete]
        public Customer Delete(Customer customer)
        {
            _CustomerService.Delete(customer);
                return customer;
        }
    }
}
