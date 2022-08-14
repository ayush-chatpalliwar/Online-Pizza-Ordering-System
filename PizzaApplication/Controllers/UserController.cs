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
    public class UserController : ControllerBase
    {
        private IUserServices service;
        public UserController(IUserServices obj)
        {
            service = obj;
        }

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            return Ok(service.AddUser(user));
        }

        [HttpPatch]
        public IActionResult UpdatePassword(LoginViewModel user)
        {
            return Ok(service.UpdatePassword(user));
        }


    }
}
