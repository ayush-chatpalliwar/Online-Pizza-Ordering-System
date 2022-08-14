using PizzaApplication.Models;
using PizzaApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.DatabaseRepo
{
    public interface IFeedbackServices
    {
        public string AddFeedback(Feedback feedback);
        public List<FeedbackViewModel> GetAllFeedback();
        public FeedbackViewModel GetFeedbackById(int id);


    }
}
