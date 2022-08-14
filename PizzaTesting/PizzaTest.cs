using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaApplication.DatabaseRepo;
using PizzaApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTesting
{
    [TestClass]
    public class PizzaTest
    {
        private PizzaRepositories pizzaService = new PizzaRepositories();

       
        [TestMethod]
        public void PizzaById()
        {
            Pizza expected = new Pizza();
            expected.PizzaId = 4;
            expected.Name = "Margherita";
            expected.Price = 250;
            expected.Category = "Veg";
            expected.Toppings = "Sweetcorn";
            expected.Date = Convert.ToDateTime("2021-05-30 20:43:20.9918805");
            expected.Image = "54e7cabc-1dd5-4f66-b107-d7cfde358723_Margherita.jpg";
            var actual = pizzaService.GetPizzaById(4);
            Assert.AreEqual(Compare(expected, actual), true);
        }
        [TestMethod]
        public void UpdatePizza()
        {
            string expect = "Pizza Updated Successfully";
            Pizza expected = new Pizza();
            expected.PizzaId = 4;
            expected.Name = "Margherita";
            expected.Price = 250;
            expected.Category = "Veg";
            expected.Toppings = "Sweetcorn";
            expected.Date = Convert.ToDateTime("2021-05-30 20:43:20.9918805");
            expected.Image = "54e7cabc-1dd5-4f66-b107-d7cfde358723_Margherita.jpg";
            string actual = pizzaService.UpdatePizza(expected);
            Assert.AreEqual(expect, actual);
        }

        public static bool Compare(Pizza expected, Pizza actual)
        {

            if (expected.PizzaId == actual.PizzaId && expected.Name.Equals(actual.Name) && expected.Category.Equals(actual.Category) && expected.Toppings.Equals(actual.Toppings) && expected.Image.Equals(actual.Image) && expected.Price == actual.Price)
            {
                return true;

            }
            else
            {
                return false;
            }
            //return isEqual;
        }


    }
}
