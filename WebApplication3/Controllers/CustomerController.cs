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
            _customerService.Add(customer);
            return customer;
        }
    }
}
