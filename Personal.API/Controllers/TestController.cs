using Application.Abstraction;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace Personal.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {

        private readonly IApiService _apiservice;

        public TestController(IApiService apiservice)
        {
            _apiservice = apiservice;
        }

        [HttpGet]
        public IActionResult GetCustomer()
        {
            var customers = _apiservice.getallCustomer();
            return Ok(customers);
        }

        [HttpPost]
        public IActionResult AddCustomer(CustomerModels customer)
        {
            _apiservice.addCustomer(customer);

            return Ok("Customer Added Successfully");
        }
    }
}