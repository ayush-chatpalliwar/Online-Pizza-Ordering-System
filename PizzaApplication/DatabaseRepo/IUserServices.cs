using PizzaApplication.Models;
using PizzaApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.DatabaseRepo
{
    public interface IUserServices
    {
        public int AddUser(User user);

        public string UpdateUser(User user);
        public int GetUserId(string email);
        public string UpdatePassword(LoginViewModel user);

    }
}
