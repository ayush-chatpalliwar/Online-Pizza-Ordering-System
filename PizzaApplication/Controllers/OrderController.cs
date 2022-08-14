using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaApplication.DatabaseRepo;
using PizzaApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IOrderServices service;
        public OrderController(IOrderServices obj)
        {
            service = obj;
        }

        [HttpPost]
        public IActionResult AddOrder(Order order)
        {
            return Ok(service.AddOrder(order));
        }

    }
}
