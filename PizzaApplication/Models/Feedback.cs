using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.Models
{
    public class Feedback
    {
        [Key]
         
        public int FeedbackId { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        public int OrderNo { get; set; }        
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

    }
}
