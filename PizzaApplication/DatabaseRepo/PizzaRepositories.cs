using PizzaApplication.DBContext;
using PizzaApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.DatabaseRepo
{
    public class PizzaRepositories : IPizzaServices
    {
        private PizzaDBContext db = new PizzaDBContext();
        public PizzaRepositories()
        {
            //db = context;
        }

        public int AddPizza(Pizza model)
        {
            return 1;
        }
        public List<Pizza> GetAllPizza()
        {
            return db.Pizzas.ToList();
        }
        public Pizza GetPizzaById(int id)
        {
            return db.Pizzas.First(x => x.PizzaId == id);
        }

        public string UpdatePizza(Pizza pizza)
        {
            
            var entity = db.Pizzas.FirstOrDefault(item => item.PizzaId == pizza.PizzaId);
            // Validate entity is not null
            if (entity != null)
            {
                entity.Name = pizza.Name;
                entity.Price = pizza.Price;
                entity.Category = pizza.Category;
                entity.Toppings = pizza.Toppings;
                db.SaveChanges();
            }
            return "Pizza Updated Successfully";
        }

        public string DeletePizza(int id)
        {
            var pizza = db.Pizzas.ToList().First(x => x.PizzaId == id);
            if (pizza != null)
            {
                db.Pizzas.Remove(pizza);
                db.SaveChanges();
            }
            return "Pizza Deleted Successfully";
        }



    }
}
