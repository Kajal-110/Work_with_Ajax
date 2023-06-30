using KajalQuizApplication.Models.Model;
using KajalQuizApplication.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KajalQuizApplication.Controllers
{
    public class LoginController : Controller
    {
        IUser UserInterface;
        public LoginController(IUser UserInterface)
        {
            this.UserInterface = UserInterface;
        }
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserModel userModel)
        {
            string Login = UserInterface.Login(userModel);
            if(Login =="" || Login == "" || Login == "")
            {
                TempData["Error"] = Login;
                return View();
            }
            else
            {
                Session["Email"] = Login;
                return RedirectToAction("Index", "Quiz");
            }
           
        }
        public ActionResult Logout()
        {
            try
            {
                Session.Abandon();
                return RedirectToAction("Login");
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}