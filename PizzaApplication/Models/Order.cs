using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        public int PizzaId { get; set; }
        [ForeignKey("PizzaId")]
        public Pizza Pizza { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime Date { get; set; }
        public int OrderNo { get; set; }
    }
}
