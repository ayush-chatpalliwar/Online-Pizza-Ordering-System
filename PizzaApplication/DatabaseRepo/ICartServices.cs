using PizzaApplication.Models;
using PizzaApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.DatabaseRepo
{
    public interface ICartServices
    {
        public string AddToCart(Cart model);
        public List<CartViewModel> GetCartByUserId(int id);
        public string BuyCart(BuyCartViewModel model);
        public string DeletePizzaFromCart(int id, int userid);


    }
}
