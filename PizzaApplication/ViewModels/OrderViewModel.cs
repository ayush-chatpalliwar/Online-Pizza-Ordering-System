using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.ViewModels
{
    public class OrderViewModel
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }         
        public int PizzaId { get; set; }
        public string PizzaName { get; set; }
        public string PizzaImage { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime Date { get; set; }
        public int OrderNo { get; set; }

    }

    public class OrderDisplayViewModel
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public List<int> PizzaId { get; set; }
        public List<string> PizzaName { get; set; }
        public List<string> PizzaImage { get; set; }
        public List<int> Quantity { get; set; }
        public int Price { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime Date { get; set; }
        public int OrderNo { get; set; }

    }
}
