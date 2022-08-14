using PizzaApplication.DBContext;
using PizzaApplication.Models;
using PizzaApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.DatabaseRepo
{
    public class OrderRepositories : IOrderServices
    {
        private PizzaDBContext db = new PizzaDBContext();
        //public OrderRepositories(PizzaDBContext context)
        //{
        //    db = context;
        //}

        public string AddOrder(Order order)
        {
            order.Price = order.Quantity*order.Price;
            order.Date = DateTime.Now;
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
            order.OrderNo = Convert.ToInt32(refer);
            db.Orders.Add(order);
            db.SaveChanges();
            return ("Order Placed Successfully with Order No - "+refer);
        }

        public List<OrderDisplayViewModel> GetOrderByUserId(int id)
        {
            var query = (from ord in db.Orders.Where(x => x.UserId == id).ToList()
                         join piz in db.Pizzas.ToList()
                         on ord.PizzaId equals piz.PizzaId

                         select new
                         {
                             OrderId = ord.OrderId,
                             UserId = ord.UserId,
                             PizzaId = piz.PizzaId,
                             PizzaName = piz.Name,
                             PizzaImage = piz.Image,
                             Quantity = ord.Quantity,
                             Price = ord.Price,
                             PaymentMethod = ord.PaymentMethod,
                             Date = ord.Date,
                             OrderNo = ord.OrderNo

                         }).OrderBy(x => x.Date).ToList();

            List<OrderViewModel> model = new List<OrderViewModel>();

            foreach (var item in query)
            {
                var OrdModel = new OrderViewModel();
                OrdModel.OrderId = item.OrderId;
                OrdModel.UserId = item.UserId;
                OrdModel.PizzaId = item.PizzaId;
                OrdModel.PizzaName = item.PizzaName;
                OrdModel.PizzaImage = item.PizzaImage;
                OrdModel.Quantity = item.Quantity;
                OrdModel.Price = item.Price;
                OrdModel.PaymentMethod = item.PaymentMethod;
                OrdModel.Date = item.Date;
                OrdModel.OrderNo = item.OrderNo;

                model.Add(OrdModel);
            }
            List<OrderDisplayViewModel> display = new List<OrderDisplayViewModel>();

            List<int> ordno = new List<int>();
            foreach (var item in model)
            {
                if (!ordno.Contains(item.OrderNo))
                {
                    var OrdModel = new OrderDisplayViewModel();
                    OrdModel.OrderId = item.OrderId;
                    OrdModel.UserId = item.UserId;
                    OrdModel.Price = item.Price;
                    OrdModel.PaymentMethod = item.PaymentMethod;
                    OrdModel.Date = item.Date;
                    OrdModel.OrderNo = item.OrderNo;
                    display.Add(OrdModel);
                    ordno.Add(item.OrderNo);
                }               
            }
            foreach (var item in display)
            {
                List<int> PizzaIds = model.Where(u => u.OrderNo == item.OrderNo).Select(u => u.PizzaId).ToList();
                item.PizzaId = PizzaIds;
                List<string> PizzaNames = model.Where(u => u.OrderNo == item.OrderNo).Select(u => u.PizzaName).ToList();
                item.PizzaName = PizzaNames;
                List<string> PizzaImages = model.Where(u => u.OrderNo == item.OrderNo).Select(u => u.PizzaImage).ToList();
                item.PizzaImage = PizzaImages;
                List<int> Quantities = model.Where(u => u.OrderNo == item.OrderNo).Select(u => u.Quantity).ToList();
                //List<string> Qtys = Quantities.ConvertAll<string>(delegate (int i) { return i.ToString(); });
                item.Quantity = Quantities;

            }
            var d = display;
             
            return display;

        }


        public List<OrderDisplayViewModel> GetAllOrders()
        {
            var query = (from ord in db.Orders.ToList()
                         join piz in db.Pizzas.ToList()
                         on ord.PizzaId equals piz.PizzaId

                         select new
                         {
                             OrderId = ord.OrderId,
                             UserId = ord.UserId,
                             PizzaId = piz.PizzaId,
                             PizzaName = piz.Name,
                             PizzaImage = piz.Image,
                             Quantity = ord.Quantity,
                             Price = ord.Price,
                             PaymentMethod = ord.PaymentMethod,
                             Date = ord.Date,
                             OrderNo = ord.OrderNo

                         }).OrderBy(x => x.Date).ToList();

            List<OrderViewModel> model = new List<OrderViewModel>();

            foreach (var item in query)
            {
                var OrdModel = new OrderViewModel();
                OrdModel.OrderId = item.OrderId;
                OrdModel.UserId = item.UserId;
                OrdModel.PizzaId = item.PizzaId;
                OrdModel.PizzaName = item.PizzaName;
                OrdModel.PizzaImage = item.PizzaImage;
                OrdModel.Quantity = item.Quantity;
                OrdModel.Price = item.Price;
                OrdModel.PaymentMethod = item.PaymentMethod;
                OrdModel.Date = item.Date;
                OrdModel.OrderNo = item.OrderNo;

                model.Add(OrdModel);
            }
            List<OrderDisplayViewModel> display = new List<OrderDisplayViewModel>();

            List<int> ordno = new List<int>();
            foreach (var item in model)
            {
                if (!ordno.Contains(item.OrderNo))
                {
                    var OrdModel = new OrderDisplayViewModel();
                    OrdModel.OrderId = item.OrderId;
                    OrdModel.UserId = item.UserId;
                    OrdModel.Price = item.Price;
                    OrdModel.PaymentMethod = item.PaymentMethod;
                    OrdModel.Date = item.Date;
                    OrdModel.OrderNo = item.OrderNo;
                    display.Add(OrdModel);
                    ordno.Add(item.OrderNo);
                }
            }
            foreach (var item in display)
            {
                List<int> PizzaIds = model.Where(u => u.OrderNo == item.OrderNo).Select(u => u.PizzaId).ToList();
                item.PizzaId = PizzaIds;
                List<string> PizzaNames = model.Where(u => u.OrderNo == item.OrderNo).Select(u => u.PizzaName).ToList();
                item.PizzaName = PizzaNames;
                List<string> PizzaImages = model.Where(u => u.OrderNo == item.OrderNo).Select(u => u.PizzaImage).ToList();
                item.PizzaImage = PizzaImages;
                List<int> Quantities = model.Where(u => u.OrderNo == item.OrderNo).Select(u => u.Quantity).ToList();
                //List<string> Qtys = Quantities.ConvertAll<string>(delegate (int i) { return i.ToString(); });
                item.Quantity = Quantities;

            }
            var d = display;

            return display;

        }




    }
}
