using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Order.BusinessLayer.Services;
using Order.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order.WebAPI.Controllers
{
    [Route("Order")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        // GET: api/orders
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _orderService.FindAllAsync();
            return Ok(result);
        }

        // POST: api/orders
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Orders order)
        {
            var result = await _orderService.InsertAsync(order);
            return Ok(result);
        }

        // PUT: api/orders
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Orders order)
        {
            var result = await _orderService.UpdateAsync(order);
            return Ok(result);
        }
        // PUT: api/orders
        [HttpGet]
        [Route("{orderId}")]
        public async Task<IActionResult> getById(int orderId)
        {
            var result = await _orderService.FindOneAsync(orderId);
            return Ok(result);
        }
    }
}


