using PizzaApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.DatabaseRepo
{
    public interface IPizzaServices
    {
        public int AddPizza(Pizza model);
        public List<Pizza> GetAllPizza();

        public Pizza GetPizzaById(int id);
        public string UpdatePizza(Pizza pizza);
        public string DeletePizza(int id);

    }
}
