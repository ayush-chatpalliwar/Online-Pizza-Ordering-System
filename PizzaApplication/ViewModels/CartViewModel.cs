using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.ViewModels
{
    public class CartViewModel
    {
        public int CartId { get; set; }
        public int UserId { get; set; }
        public int PizzaId { get; set; }
        public string PizzaName { get; set; }
        public string PizzaImage { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

    }
    public class BuyCartViewModel
    {
        public int[] Quantity { get; set; }
        public string payment { get; set; }
        public int UserId { get; set; }
        public int Total { get; set; }
    }
}
