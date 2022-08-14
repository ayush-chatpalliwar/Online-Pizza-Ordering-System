using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaApplication.DatabaseRepo;
using PizzaApplication.Models;
using PizzaApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private ICartServices service;
        private IUserServices userService;
        public CartController(ICartServices obj, IUserServices obj2)
        {
            service = obj;
            userService = obj2;
        }

        [HttpPost]
        public IActionResult AddToCart(Cart cart)
        {
            return Ok(service.AddToCart(cart));
        }

        [HttpPatch]
        public IActionResult BuyCart(BuyCartViewModel model)
        {
            return Ok(service.BuyCart(model));
        }


        [HttpDelete("{id}")]
        public IActionResult DeletePizzaFromCart([FromRoute] int id)
        {
            int userid = userService.GetUserId(User.Identity.Name);
            return Ok(service.DeletePizzaFromCart(id, userid));
        }


    }
}
