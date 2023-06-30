using Ajax_Practice__2.Models.DbContext;
using Ajax_Practice__2.Models.Models;
using Ajax_Practice__2.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ajax_Practice__2.Controllers
{
    public class UserController : Controller
    {
        IUser UserInterface;
        public UserController(IUser UserInterface)
        {
            this.UserInterface = UserInterface;
        }
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetAllUser()
        {
            var user = UserInterface.GetAllUser();
            return Json(user, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public JsonResult Create(UserModel userModel )
        {
            int user = UserInterface.AddUpdateTeacher(userModel);
            if (user == 1)
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
            UserRecord userRecord = new UserRecord();

            userRecord = UserInterface.DeleteUser(id);

            return Json(new { success = true }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult Edit(int id)
        {
            var edit = UserInterface.EditUser(id);
            return Json(edit, JsonRequestBehavior.AllowGet);
        }
    }
}