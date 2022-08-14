using PizzaApplication.DBContext;
using PizzaApplication.Models;
using PizzaApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.DatabaseRepo
{
    public class CartRepositories : ICartServices
    {
        private PizzaDBContext db;
         
        public CartRepositories(PizzaDBContext context)
        {
            db = context;
             
        }

        public string AddToCart(Cart model)
        {
            bool isvalid = db.Carts.Any(x => x.UserId == model.UserId && x.PizzaId == model.PizzaId);
            if (isvalid == false)
            {
                db.Carts.Add(model);
                db.SaveChanges();
            }           
            return "Pizza Added To Cart";
        }

        public List<CartViewModel> GetCartByUserId(int id)
        {
            var query = (from cart in db.Carts.Where(x => x.UserId == id).ToList()
                         join piz in db.Pizzas.ToList()
                         on cart.PizzaId equals piz.PizzaId

                         select new
                         {
                             CartId = cart.CartId,
                             UserId = cart.UserId,
                             PizzaId = piz.PizzaId,
                             PizzaName = piz.Name,
                             PizzaImage = piz.Image,
                             Quantity = cart.Quantity,
                             Price = piz.Price,

                         }).OrderBy(x => x.CartId).ToList();

            List<CartViewModel> model = new List<CartViewModel>();


            foreach (var item in query)
            {
                var CartModel = new CartViewModel();
                CartModel.CartId = item.CartId;
                CartModel.UserId = item.UserId;
                CartModel.PizzaId = item.PizzaId;
                CartModel.PizzaName = item.PizzaName;
                CartModel.PizzaImage = item.PizzaImage;
                CartModel.Quantity = item.Quantity;
                CartModel.Price = item.Price;
  
                model.Add(CartModel);
            }
            return model;

        }

        public string BuyCart(BuyCartViewModel model)
        {
            var cart = db.Carts.Where(x => x.UserId == model.UserId);
            int iOTPLength = 6;
            string[] saAllowedCharacters = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            string refer = String.Empty;
            string sTempChars = String.Empty;
            Random rand = new Random();
            for (int a = 0; a < iOTPLength; a++)

            {
                int p = rand.Next(0, saAllowedCharacters.Length);
                sTempChars = saAllowedCharacters[rand.Next(0, saAllowedCharacters.Length)];
                refer += sTempChars;
            }
            
            int i = 0;
            foreach (var item in cart)
            {
                Order ord = new Order();
                ord.UserId = model.UserId;
                ord.PizzaId = item.PizzaId;
                ord.Quantity = model.Quantity[i];
                ord.Price = model.Total;
                ord.PaymentMethod = model.payment;
                ord.Date = DateTime.Now;
                ord.OrderNo = Convert.ToInt32(refer);
                db.Orders.Add(ord);
                
                i = i + 1;
            }
            db.SaveChanges();
            foreach (var item in cart)
            {
                db.Carts.Remove(item);
            }
            db.SaveChanges();

            return "Order Placed Sucessfully with the Order No - "+ refer;
        }

        public string DeletePizzaFromCart(int id, int userid)
        {
            var pizza = db.Carts.ToList().First(x => x.PizzaId == id && x.UserId == userid);
            if (pizza != null)
            {
                db.Carts.Remove(pizza);
                db.SaveChanges();
            }
            return "Pizza Removed From Cart";
        }



    }
}
