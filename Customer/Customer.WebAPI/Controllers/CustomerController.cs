using Customer.BusinessLayer.Services;
using Customer.Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customer.WebAPI.Controllers
{
    [Route("Customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        // GET: api/customers
        [HttpGet]
        public async Task<IActionResult> GetCustomer()
        {
            var result = await _customerService.FindAllAsync();
            return Ok(result);
        }

        // POST: api/customers
        [HttpPost]
        public async Task<IActionResult> PostCustomer([FromBody] Customers customer)
        {
            var result = await _customerService.InsertAsync(customer);
            return Ok(result);
        }

        // PUT: api/customers 
        [HttpPut]
        public async Task<IActionResult> PutCustomer([FromBody] Customers customer)
        {
            var result = await _customerService.UpdateAsync(customer);
            return Ok(result);
        }

        // PUT: api/customers 
        [HttpGet]
        [Route("{customerId}")]
        public async Task<IActionResult> GetCustomerById(int customerId)
        {
            var result = await _customerService.FindOneAsync(customerId);
            return Ok(result);
        }

    }
}
