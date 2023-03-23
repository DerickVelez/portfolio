using CarHire.Service;
using CarHire_.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarHire.WebAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private static CustomerService _customerService { get; set; } = new CustomerService();

        [HttpGet]
        public List<Customer> GetCustomers()
        {
            return _customerService.GetCustomers(); 
        }
        [HttpPost]
        public Customer Add(Customer customer)
        {
            var alreadyregistered = _customerService.IsAlreadyRegistered(customer.CustomerID);
            if (alreadyregistered)
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
