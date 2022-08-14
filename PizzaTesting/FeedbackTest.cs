using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaApplication.DatabaseRepo;
using PizzaApplication.Models;
using PizzaApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTesting
{
    [TestClass]
    public class FeedbackTest
    {
        private FeedbackRepositories feedbackService = new FeedbackRepositories();

        [TestMethod]
        public void FeedbackById()
        {
            FeedbackViewModel expected = new FeedbackViewModel();
            expected.FeedbackId = 2;
            expected.UserId = 7;
            expected.UserName = "Yogesh";
            expected.OrderNo = 792531;
            expected.Title = "Good Taste";
            expected.Description = "Very good taste. Loved it";
            var actual = feedbackService.GetFeedbackById(2);
            Assert.AreEqual(Compare(expected, actual), true);
        }

        public static bool Compare(FeedbackViewModel expected, FeedbackViewModel actual)
        {

            if (expected.FeedbackId == actual.FeedbackId && expected.UserName.Equals(actual.UserName) && expected.Title.Equals(actual.Title) && expected.Description.Equals(actual.Description) && expected.OrderNo == actual.OrderNo)
            {
                return true;

            }
            else
            {
                return false;
            }
            //return isEqual;
        }

        //[TestMethod]
        //public void AddFeedback()
        //{
        //    string exp = "Thank You For Your Feedback";
        //    Feedback expected = new Feedback();
        //    //expected.FeedbackId = 2;
        //    expected.UserId = 7;
        //    expected.OrderNo = 792531;
        //    expected.Title = "Good Taste";
        //    expected.Description = "Very good taste. Loved it";
        //    expected.Date = DateTime.Now;
        //    string actual = feedbackService.AddFeedback(expected);
        //    Assert.AreEqual(exp, actual);
        //}




    }
}
