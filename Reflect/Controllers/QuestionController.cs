using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Reflect.Azure.Entities;
using Reflect.Models;

namespace Reflect.Controllers
{
    public class QuestionController : Controller
    {
        // GET: Question
        public ActionResult Index()
        {
         var model = new HomeViewModel() {
            Questions = GetQuestions()
         };
            return View("~/Views/Home/Index.cshtml", model);
        }
      
      public List<Question> GetQuestions() {
         
         try {
            var questions = new List<Question>();
            using(var context = new Azure.AzureContext()) {
               questions = context.Questions.Take(5).OrderByDescending(x => x.CreatedDate).ToList();
            }

            return questions;
         } catch(Exception ex) {

            throw ex;
         }

      }
      public ActionResult Ask(string title, string content) {
         
         try {
            if(!String.IsNullOrWhiteSpace(title) && !String.IsNullOrWhiteSpace(content)) {
               var question = new Question() {
                  Title = title,
                  Content = content,
                  CreatedDate = DateTime.Now

               };
               using(var context = new Azure.AzureContext()) {
                  context.Questions.Add(question );

                  context.SaveChanges();
               }

              return PartialView("_Question", question);
            }
         } catch(Exception ex) {

            throw ex;
         }


         return new JsonResult() { JsonRequestBehavior = JsonRequestBehavior.AllowGet, Data = "Error" };
      }

    }
}