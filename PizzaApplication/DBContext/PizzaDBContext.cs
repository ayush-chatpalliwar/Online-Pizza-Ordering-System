using Microsoft.EntityFrameworkCore;
using PizzaApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.DBContext
{
    public class PizzaDBContext : DbContext
    {
        //public PizzaDBContext(DbContextOptions<PizzaDBContext> options) : base(options)
        //{
             
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server= LAPTOP-GVP2GN24;Database=PizzaDB;Trusted_Connection=True;");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Cart> Carts { get; set; }

    }

}
