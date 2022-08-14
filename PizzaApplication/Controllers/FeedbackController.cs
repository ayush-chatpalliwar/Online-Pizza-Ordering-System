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
    public class FeedbackController : ControllerBase
    {
        private IFeedbackServices service;
        public FeedbackController(IFeedbackServices obj)
        {
            service = obj;
        }

        [HttpPost]
        public IActionResult AddFeedback(Feedback feedback)
        {
            return Ok(service.AddFeedback(feedback));
        }

    }
}
