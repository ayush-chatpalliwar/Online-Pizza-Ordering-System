using PizzaApplication.Models;
using PizzaApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.DatabaseRepo
{
     public interface IOrderServices
    {
        public string AddOrder(Order order);
        public List<OrderDisplayViewModel> GetOrderByUserId(int id);
        public List<OrderDisplayViewModel> GetAllOrders();
    }
}
