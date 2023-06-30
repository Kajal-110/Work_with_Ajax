using KajalQuizApplication.Repository.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KajalQuizApplication.Controllers
{
    public class QuizController : Controller
    {
        IQuiz QuizInterface;
        public QuizController(IQuiz QuizInterface)
        {
            this.QuizInterface = QuizInterface;
        }
        // GET: Quiz
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetQuestionList()
        {
            var question = QuizInterface.GetQuestions();
            var aa = JsonConvert.SerializeObject(question);
            return Json(aa, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetAnswerList()
        {
            var answer = QuizInterface.GetAnswers();
            var aa = JsonConvert.SerializeObject(answer);
            return Json(aa, JsonRequestBehavior.AllowGet);
        }
    }
}