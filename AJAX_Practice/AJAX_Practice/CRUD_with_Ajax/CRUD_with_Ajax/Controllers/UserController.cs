using CRUD_with_Ajax.Model.DbContext;
using CRUD_with_Ajax.Model.Models;
using CRUD_with_Ajax.Repository.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_with_Ajax.Controllers
{
    public class UserController : Controller
    {
        AjaxPracticeEntities db = new AjaxPracticeEntities();

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
        [HttpPost]
        public JsonResult AddUser(UserModel userModel)
        {
            string Message = "Data Updated";
            var aa=UserInterface.Register(userModel);
            if (userModel.UserId <= 0)
            {

                return Json(new { Success = 1, data = aa }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { Success = 0, data = "" }, JsonRequestBehavior.AllowGet);
            }

            User user = db.Users.SingleOrDefault(x => x.UserId == userModel.UserId) ?? new User();

            user.UserId = userModel.UserId;
            user.UserName = userModel.UserName;
            user.Address = userModel.Address;
            user.Gender = userModel.Gender;
            user.DOB = userModel.DOB;
            user.PhoneNo = userModel.PhoneNo;
            user.Role = userModel.Role;
           if(userModel.UserId == 0)
            {
                Message = "Data added";
                db.Users.Add(user);
            }
            db.SaveChanges();
            return Json(new { Success= true,Message= Message }, JsonRequestBehavior.AllowGet);
        }
       
        public JsonResult GetAllUsers()
        {
            var user = db.Users.ToList();
            //var users = JsonConvert.SerializeObject(user);
            return Json( user, JsonRequestBehavior.AllowGet);

            //return Json(new { Success=true,data=users}, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult DeleteUser(int id)
        {
            User user = new User();
            user = db.Users.Where(x=>x.UserId== id).FirstOrDefault();
             var aa=db.Users.Remove(user);
            db.SaveChanges();
            return Json(new { success = true }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult EditUser(int id)
        {
            var edit = db.Users.SingleOrDefault(x => x.UserId == id);
            return Json(edit, JsonRequestBehavior.AllowGet);
        }

        //[HttpGet]
        //public ActionResult AddUser(int ? id)
        //{           

        //   if (id != 0)
        //   {

        //       // UserInterface.Register();
        //        return View();
        //   }                
        //   else
        //   {
        //         return View();
        //   }

        //}
        //[HttpPost]
        //public JsonResult AddUser(UserModel userModel)
        //{
        //    if (userModel.UserId <= 0)
        //    {
        //        User user = new User
        //        {
        //            UserName = userModel.UserName,
        //            Address = userModel.Address,
        //            Gender = userModel.Gender,
        //            DOB = userModel.DOB,
        //            PhoneNo = userModel.PhoneNo,
        //            Role=userModel.Role,
        //            IsDeleted=userModel.IsDeleted

        //        };
        //        db.Users.Add(user);
        //        db.SaveChanges();
        //        return Json(user, JsonRequestBehavior.AllowGet);
        //    }
        //    else
        //    {
        //        return Json("",JsonRequestBehavior.AllowGet);
        //    }
        //}

    }
}