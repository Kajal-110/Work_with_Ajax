using KajalQuizApplication.Models.DbContext;
using KajalQuizApplication.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KajalQuizApplication.Controllers
{

    public class HomeController : Controller
    {
        QuestionManagementEntities db = new QuestionManagementEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Student()
        {
            return View();
        }
        public void InsertRecord(StudentModel studentModel)
        {
            if(studentModel.Id != 0)
            {
                 db.Insert_Student(studentModel.Name, studentModel.Mobile, studentModel.Email);
            }
            else
            {
                db.Update_Student(null, studentModel.Name, studentModel.Mobile, studentModel.Email);
                db.SaveChanges();
            }

        }
        public JsonResult GetStudentRecord()
        
        {
            var data = db.StudentRecord.ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public JsonResult EditStudentRecord(int id)
        {
            var edit = db.StudentRecord.Find(id); ;
            return Json(edit, JsonRequestBehavior.AllowGet);
        }
    }
}