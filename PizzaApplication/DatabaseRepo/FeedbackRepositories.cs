using PizzaApplication.DBContext;
using PizzaApplication.Models;
using PizzaApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.DatabaseRepo
{
    public class FeedbackRepositories : IFeedbackServices
    {
        private PizzaDBContext db = new PizzaDBContext();
        //public FeedbackRepositories(PizzaDBContext context)
        //{
        //    db = context;
        //}

        public string AddFeedback(Feedback feedback)
        {
            feedback.Date = DateTime.Now;
            db.Feedbacks.Add(feedback);
            db.SaveChanges();
            return "Thank You For Your Feedback";
        }

        public List<FeedbackViewModel> GetAllFeedback()
        {
            var query = (from feed in db.Feedbacks.ToList()
                         join user in db.Users.ToList()
                         on feed.UserId equals user.UserId

                         select new
                         {
                             FeedbackId = feed.FeedbackId,
                             UserId = feed.UserId,
                             UserName = user.Name,
                             OrderNo = feed.OrderNo,
                             Title = feed.Title,
                             Description = feed.Description,
                             Date = feed.Date,

                         }).OrderBy(x => x.FeedbackId).ToList();

            List<FeedbackViewModel> model = new List<FeedbackViewModel>();
            foreach (var item in query)
            {
                var FeedModel = new FeedbackViewModel();
                FeedModel.FeedbackId = item.FeedbackId;
                FeedModel.UserId = item.UserId;
                FeedModel.UserName = item.UserName;
                FeedModel.OrderNo = item.OrderNo;
                FeedModel.Title = item.Title;
                FeedModel.Description = item.Description;
                FeedModel.Date = item.Date;
                 
                model.Add(FeedModel);
            }

            return model;
        }


        public FeedbackViewModel GetFeedbackById(int id)
        {
            var query = (from feed in db.Feedbacks.Where(x => x.FeedbackId == id).ToList()
                         join user in db.Users.ToList()
                         on feed.UserId equals user.UserId

                         select new
                         {
                             FeedbackId = feed.FeedbackId,
                             UserId = feed.UserId,
                             UserName = user.Name,
                             OrderNo = feed.OrderNo,
                             Title = feed.Title,
                             Description = feed.Description,
                             Date = feed.Date,

                         }).OrderBy(x => x.FeedbackId).ToList();

            FeedbackViewModel model = new FeedbackViewModel();
            foreach (var item in query)
            {
                var FeedModel = new FeedbackViewModel();
                FeedModel.FeedbackId = item.FeedbackId;
                FeedModel.UserId = item.UserId;
                FeedModel.UserName = item.UserName;
                FeedModel.OrderNo = item.OrderNo;
                FeedModel.Title = item.Title;
                FeedModel.Description = item.Description;
                FeedModel.Date = item.Date;

                model = FeedModel;
            }

            return model;
        }




    }
}
