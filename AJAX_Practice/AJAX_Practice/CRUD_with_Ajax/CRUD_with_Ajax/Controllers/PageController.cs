using CRUD_with_Ajax.Model.DbContext;
using CRUD_with_Ajax.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_with_Ajax.Controllers
{
    public class PageController : Controller
    {
        // GET: Page
        public ActionResult Index()
        {
            return View(this.GetTeachers(1));
        }
        [HttpPost]
        public ActionResult Index( int CurrentPageIndex)
        {
            return View(this.GetTeachers(CurrentPageIndex));
        }

        private PageModel GetTeachers(int CurrentPage)
        {
            int maxRow = 3;
            using (AjaxPracticeEntities db = new AjaxPracticeEntities())
            {
                PageModel pageModel = new PageModel();
                pageModel.Teacher = (from Teacher in db.Teachers
                                     select Teacher).
                                 OrderBy(Teacher => Teacher.Id).
                                 Skip((CurrentPage - 1) * maxRow).
                                 Take(maxRow).ToList();
                double pageCount = (double)((decimal)db.Teachers.Count()/Convert.ToDecimal(maxRow));
                pageModel.PageCount = (int)Math.Ceiling(pageCount);
                pageModel.CurrentPageIndex = CurrentPage;
                return pageModel;
            }
        } 
    }
}