using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using PizzaApplication.DatabaseRepo;
using PizzaApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTesting
{
    [TestClass]
    public class OrderTest
    {
        private OrderRepositories orderService = new OrderRepositories();

        [TestMethod]
        public void OrderkByUserId()
        {
            List<OrderDisplayViewModel> expected = new List<OrderDisplayViewModel>();
            var model = new OrderDisplayViewModel();
            model.OrderId = 1026;
            model.UserId = 3;
            List<int> pid = new List<int>();
            pid.Add(5);
            model.PizzaId = pid;

            List<string> pname = new List<string>();
            pname.Add("Pepperoni");
            model.PizzaName = pname;

            List<string> pimage = new List<string>();
            pimage.Add("af153615-9871-4ece-9b14-92509e76d972_Pepperoni.jpg");
            model.PizzaImage = pimage;

            List<int> pqty = new List<int>();
            pqty.Add(2);
            model.Quantity = pqty;

            model.Price = 600;
            model.PaymentMethod = "Credit Card";
            model.Date = Convert.ToDateTime("2021-06-08 16:21:25.8084285");
            model.OrderNo = 737476;
            expected.Add(model);
            var actual = orderService.GetOrderByUserId(3);
            bool res = actual.SequenceEqual(expected);
            //NUnit.Framework.Assert.That(actual, Is.EquivalentTo(expected));
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(Compare(expected, actual), true);
        }


        public static bool Compare(List<OrderDisplayViewModel> expected, List<OrderDisplayViewModel> actual)
        {
            bool isEqual = true;
            for (int i = 0; i < actual.Count; i++)
            {
                if (expected[i].UserId == actual[i].UserId && expected[i].Price == actual[i].Price && expected[i].Date == actual[i].Date && expected[i].OrderNo == actual[i].OrderNo)
                {
                    isEqual = true;

                }
                else
                {
                    isEqual = false;
                }
            }
            
            
            return isEqual;
        }




    }
}
