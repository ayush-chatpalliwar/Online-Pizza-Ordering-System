using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using PizzaApplication.DatabaseRepo;
using PizzaApplication.DBContext;
using PizzaApplication.Models;
using PizzaApplication.ViewModels;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Newtonsoft.Json;
using PizzaApplication.CustomException;

namespace PizzaApplication.Controllers
{
    public class OnlinePizza : Controller
    {
        private readonly IWebHostEnvironment webHostEnvironment;
        private PizzaDBContext db;
        private IPizzaServices pizzaService;
        private IUserServices userService;
        private IOrderServices orderService;
        private ICartServices cartService;
        private IFeedbackServices feedbackService;

        public OnlinePizza(PizzaDBContext context, /*SignInManager<IdentityUser> sm,*/ IWebHostEnvironment hostEnvironment, IPizzaServices obj, IUserServices obj2, IOrderServices obj3, ICartServices obj4, IFeedbackServices obj5)
        {
            webHostEnvironment = hostEnvironment;
            db = context;
            pizzaService = obj;
            userService = obj2;
            orderService = obj3;
            cartService = obj4;
            feedbackService = obj5;

            //_sm = sm;

        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login(string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel lg)
        {
            bool isAdmin = db.Users.Any(x => x.Email == lg.Email && x.Password == lg.Password && x.Role == "Admin");
            bool isUser = db.Users.Any(x => x.Email == lg.Email && x.Password == lg.Password && x.Role == "User");

            if (isAdmin == true)
            {
                var claims = new List<Claim>();
                claims.Add(new Claim("username", lg.Email));
                claims.Add(new Claim(ClaimTypes.NameIdentifier, lg.Email));
                claims.Add(new Claim(ClaimTypes.Name, lg.Email));
                claims.Add(new Claim(ClaimTypes.Role, "Admin"));
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal, new AuthenticationProperties { IsPersistent = true });
                return RedirectToAction("Menu", "OnlinePizza");
            }
            else if (isUser == true)
            {
                var claims = new List<Claim>();
                claims.Add(new Claim("username", lg.Email));
                claims.Add(new Claim(ClaimTypes.NameIdentifier, lg.Email));
                claims.Add(new Claim(ClaimTypes.Name, lg.Email));
                claims.Add(new Claim(ClaimTypes.Role, "User"));
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal, new AuthenticationProperties { IsPersistent = true });
                return RedirectToAction("Home", "OnlinePizza");
            }
            else
            {
                ViewBag.Message = "Invalid Email Or Password";
            }
            return View();
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "OnlinePizza");
        }
        public IActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            bool isvalid = db.Users.Any(x => x.Email == user.Email);
            if (isvalid == false)
            {
                int i = userService.AddUser(user);
                if (i >= 1)
                {
                    return RedirectToAction("Login", "OnlinePizza");

                }
                else
                {
                    ViewBag.Message = "Registration Failed";

                }
            }
            else
            {
                ViewBag.Message = "Email Already Exists";
            }

            return View();
        }
        [Authorize(Roles = "User")]
        public IActionResult BuyPizza(int id)
        {
            Pizza pizza = new Pizza();
            pizza = pizzaService.GetPizzaById(id);
            int userid = userService.GetUserId(User.Identity.Name);
            ViewBag.Message = pizza;
            ViewBag.UserId = userid;

            return View();
        }
        [Authorize(Roles = "User")]
        public IActionResult MyOrders()
        {
            int userid = userService.GetUserId(User.Identity.Name);
            List<OrderDisplayViewModel> ord = new List<OrderDisplayViewModel>();
            ord = orderService.GetOrderByUserId(userid);
            return View(ord);
        }

        [Authorize(Roles = "User")]
        public IActionResult Cart()
        {
            int userid = userService.GetUserId(User.Identity.Name);
            List<CartViewModel> cart = new List<CartViewModel>();
            cart = cartService.GetCartByUserId(userid);
            ViewBag.UserId = userid;
            return View(cart);
        }

        [Authorize(Roles = "User")]
        public IActionResult SendFeedback(int id)
        {
            int userid = userService.GetUserId(User.Identity.Name);
            ViewBag.UserId = userid;
            ViewBag.Message = id;

            return View();
        }

        [Authorize(Roles = "User")]
        public IActionResult Home()
        {
            int userid = userService.GetUserId(User.Identity.Name);
            List<Pizza> pizza = new List<Pizza>();
            pizza = pizzaService.GetAllPizza();
            ViewBag.UserId = userid;
            ViewBag.Message = pizza;
            
            return View();
        }

        [Authorize]
        public IActionResult Home2()
        {
            List<Pizza> pizza = new List<Pizza>();
            pizza = pizzaService.GetAllPizza();
            ViewBag.Message = pizza;
            ViewBag.Username = User.Identity.Name;
            return View(pizza);
        }

        
        public IActionResult Menu2()
        {
            List<Pizza> pizza = new List<Pizza>();
            pizza = pizzaService.GetAllPizza();
            ViewBag.Message = pizza;
            return View(pizza);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Menu()
        {
            List<Pizza> pizza = new List<Pizza>();
            pizza = pizzaService.GetAllPizza();
            ViewBag.Message = pizza;
            return View() ;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult AllOrders()
        {
            //int userid = userService.GetUserId(User.Identity.Name);
            List<OrderDisplayViewModel> ord = new List<OrderDisplayViewModel>();
            ord = orderService.GetAllOrders();
            return View(ord.OrderBy(x => x.Date));
        }

        [Authorize(Roles = "Admin")]
        public IActionResult AllFeedbacks()
        {
            List<FeedbackViewModel> feedback = new List<FeedbackViewModel>();
            feedback = feedbackService.GetAllFeedback();
            //ViewBag.Message = pizza;
            return View(feedback);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult ViewFeedback(int id)
        {
            FeedbackViewModel feedback = new FeedbackViewModel();
            feedback = feedbackService.GetFeedbackById(id);
            ViewBag.Message = feedback;
            return View();
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Sales()
        {
            List<GraphViewModel> graph = new List<GraphViewModel>();
            var myData = db.Orders.OrderBy(x => x.Date).ToList();

            List<string> dates = new List<string>();
            foreach (var item in myData)
            {
                if (!dates.Contains(item.Date.ToString("dd/MM/yyyy")))
                {
                    dates.Add(item.Date.ToString("dd/MM/yyyy"));
                }

            }
            List<int> ordno = new List<int>();
            foreach (var item in dates)
            {
                var dataset = myData.Where(u => u.Date.ToString("dd/MM/yyyy") == item).Select(u => new { u.Price, u.OrderNo }).ToList();
                int total = 0;
                
                    foreach (var i in dataset)
                    {
                        if (!ordno.Contains(i.OrderNo))
                        {
                            total = total + i.Price;
                            ordno.Add(i.OrderNo);
                        }
                    }
                
                graph.Add(new GraphViewModel(item, total));
            }
 
            ViewBag.DataPoints = JsonConvert.SerializeObject(graph);

            return View();
        }


        [Authorize(Roles = "Admin")]
        public IActionResult AddPizza()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPizza(PizzaViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    bool isvalid = db.Pizzas.Any(x => x.Name == model.Name);
                    if (isvalid == true)
                    {
                        throw new InvalidNameException("Pizza Already Exists");
                    }
                    string uniqueFileName = UploadedFile(model);

                    Pizza employee = new Pizza
                    {
                        Name = model.Name,
                        Price = model.Price,
                        Category = model.Category,
                        Toppings = model.Toppings,
                        Date = DateTime.Now,
                        Image = uniqueFileName,
                    };
                    db.Pizzas.Add(employee);
                    db.SaveChanges();
                    return RedirectToAction("Menu");
                }
                catch (InvalidNameException e)
                {
                    ViewBag.Message = "Pizza Already Exists";
                }
                
            }
            return View();
        }

        private string UploadedFile(PizzaViewModel model)
        {
            string uniqueFileName = null;

            if (model.Image != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "Images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Image.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Image.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult UpdatePizza(int id)
        {
            Pizza pizza = new Pizza();
            pizza = pizzaService.GetPizzaById(id);
            ViewBag.Message = pizza;
            return View();
        }

        [Authorize(Roles = "User")]
        public IActionResult UpdatePassword()
        {
            int userid = userService.GetUserId(User.Identity.Name);
            ViewBag.UserId = userid;
            return View();
        }
         
        public IActionResult AccessDenied()
        {
            return View();
        }


    }
}
