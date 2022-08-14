using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.Models
{
    public class Pizza
    { 
        [Key]
         
        public int PizzaId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
        public string Toppings { get; set; }
        public DateTime Date { get; set; }        
        public string Image { get; set; }
 
    }
}
