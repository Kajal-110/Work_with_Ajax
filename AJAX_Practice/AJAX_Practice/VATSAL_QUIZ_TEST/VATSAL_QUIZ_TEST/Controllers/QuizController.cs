using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VATSAL_QUIZ_TEST.REPOSITORY.Repository;

namespace VATSAL_QUIZ_TEST.Controllers
{
    [Authorize]
    public class QuizController : Controller
    {
        public IQuizInterface Iquiz;

        public QuizController(IQuizInterface _Iquiz)
        {
            Iquiz = _Iquiz;
        }
        // GET: Quiz
        public ActionResult DashBoard()
        {
            return View();
        }

        public JsonResult QuestionList()
        {
            var questions = Iquiz.QuestionList().ToList();
            var jsonQuesData = JsonConvert.SerializeObject(questions);
            return Json(jsonQuesData, JsonRequestBehavior.AllowGet);
        }
        public JsonResult AnswerList()
        {
            var answers = Iquiz.AnswerList().ToList();
            var jsonAnsData = JsonConvert.SerializeObject(answers);
            return Json(jsonAnsData, JsonRequestBehavior.AllowGet);
        }
    }
}