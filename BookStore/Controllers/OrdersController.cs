using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.ModelDtos;
using BookStore.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrdersService ordersService;

        public OrdersController(IOrdersService ordersService)
        {
            this.ordersService = ordersService;
        }
        [HttpPost]
        public IActionResult Create(CreateOrderDto order)
        {
            var response=ordersService.Create(order);

            return Ok(response.OrderCode);
        }

        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet]
        [Route("retrieve")]
        public IActionResult Retrieve(string email,string orderCode)
        {
            var order = ordersService.GetOrder(email, orderCode);
            return Ok(order);
        }


    }
}