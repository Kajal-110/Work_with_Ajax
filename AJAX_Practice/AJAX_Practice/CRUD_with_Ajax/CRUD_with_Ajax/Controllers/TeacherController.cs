using CRUD_with_Ajax.Model.DbContext;
using CRUD_with_Ajax.Model.Models;
using CRUD_with_Ajax.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_with_Ajax.Controllers
{
    public class TeacherController : Controller
    {
        ITeacher TeacherInterface;
        public TeacherController(ITeacher TeacherInterface)
        {
            this.TeacherInterface = TeacherInterface;
        }
        // GET: Teacher
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetAllTeacher()
        {
            var teacher = TeacherInterface.GetAllTeacher();
            return Json(teacher, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Create(TeacherModel teacherModel )
        {
            int teacher = TeacherInterface.AddUpdateTeacher(teacherModel);
            if(teacher == 1)
            {
                return Json(new { Success = true }, JsonRequestBehavior.AllowGet);
            }
            else if (!ModelState.IsValid)
            {
                return Json("", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { Success = false }, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpPost]
        public JsonResult Delete(int id)
        {
            Teacher teacher = new Teacher();
            teacher = TeacherInterface.DeleteTecher(id);
            
            return Json(new { success = true }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Edit(int id)
        {
            var edit = TeacherInterface.EditTeacher(id);
            return Json(edit, JsonRequestBehavior.AllowGet);
        }
    }
}