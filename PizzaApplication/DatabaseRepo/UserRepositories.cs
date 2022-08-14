using Microsoft.EntityFrameworkCore;
using PizzaApplication.DBContext;
using PizzaApplication.Models;
using PizzaApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.DatabaseRepo
{
    public class UserRepositories : IUserServices
    {
        private PizzaDBContext db;
        public UserRepositories(PizzaDBContext context)
        {
            db = context;
        }
        public int AddUser(User model)
        {
            User addUser = new User()
            {
                Name = model.Name,
                Email = model.Email,
                Password = model.Password,
                Address = model.Address,
                Date = DateTime.Now,
                Role = "User"
            };
            db.Users.Add(addUser);
            int i = db.SaveChanges();
            return i ;
        }

        public string UpdateUser(User user)
        {
            var local = db.Set<User>().Local.FirstOrDefault(entry => entry.UserId == user.UserId);

            if (local != null)     //check if local is not null
            {
                db.Entry(local).State = EntityState.Detached;       //detach
            }

            db.Entry(user).State = EntityState.Modified;        //set Modified flag in your entry
            db.SaveChanges();
            return ("User Updated Successfully");
        }

        public int GetUserId(string email)
        {
            var data = db.Users.Where(x => x.Email == email).FirstOrDefault();
            if (data != null)
            {
                return data.UserId;
            }
            else
            {
                return 0;
            }
        }

        public string UpdatePassword(LoginViewModel user)
        {
            var entity = db.Users.FirstOrDefault(item => item.UserId == user.UserId);
            // Validate entity is not null
            if (user.Email == entity.Email)
            {
                if (entity != null)
                {
                    entity.Password = user.Password;
                    db.SaveChanges();
                }
                return "Password Updated Successfully";
            }

            else

            {
                return "Invalid Email";
            }
            
            
        }


    }
}
