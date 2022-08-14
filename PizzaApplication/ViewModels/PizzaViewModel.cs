using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.ViewModels
{
    public class PizzaViewModel
    {
        public int PizzaId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
        public string Toppings { get; set; }
        public DateTime Date { get; set; }
        public IFormFile Image { get; set; }

    }
}
