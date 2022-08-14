using Microsoft.AspNetCore.Authorization;
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
    public class PizzaController : ControllerBase
    {
        private IPizzaServices service;
        public PizzaController(IPizzaServices obj)
        {
            service = obj;
        }

        //[Authorize(Roles = "Admin")]
        [HttpGet]
        [Route("~/api/GetPizzas")]
        public IActionResult GetAllPizza()
        {
            return Ok(service.GetAllPizza());
        }

        [HttpPatch]
        [Route("~/api/UpdatePizza")]
        public IActionResult UpdatePizza(Pizza pizza)
        {
            return Ok(service.UpdatePizza(pizza));
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePizza([FromRoute] int id)
        {
            return Ok(service.DeletePizza(id));
        }



    }
}
