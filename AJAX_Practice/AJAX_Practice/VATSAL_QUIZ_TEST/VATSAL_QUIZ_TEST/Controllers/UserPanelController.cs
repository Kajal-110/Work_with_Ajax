using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using VATSAL_QUIZ_TEST.MODELS.Model;
using VATSAL_QUIZ_TEST.REPOSITORY.Repository;

namespace VATSAL_QUIZ_TEST.Controllers
{
    public class UserPanelController : Controller
    {
        public IUserInterface Iuser;

        public UserPanelController(IUserInterface _Iuser)
        {
            Iuser = _Iuser;
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserDataModel user)
        {
            int success = Iuser.LoginVerify(user);
            if(success == 3)
            {
                TempData["Error"] = "User is not registered!!";
                return RedirectToAction("Login");
            }
            else if(success == 2)
            {
                TempData["Error"] = "Invalid Password";
                return RedirectToAction("Login");
            }
            else if (success == 1)
            {
                FormsAuthentication.SetAuthCookie(user.EMAIL, false);
                Session["UserEmail"] = user.EMAIL;
                return RedirectToAction("DashBoard", "Quiz");
            }
            else
            {
                TempData["Error"] = "Something Went Wrong!!";
                return RedirectToAction("Login");
            }
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            Session.Clear();
            return RedirectToAction("Login");
        }
    }
}