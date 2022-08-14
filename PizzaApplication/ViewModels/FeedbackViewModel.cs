using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.ViewModels
{
    public class FeedbackViewModel
    {
        public int FeedbackId { get; set; }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public int OrderNo { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
