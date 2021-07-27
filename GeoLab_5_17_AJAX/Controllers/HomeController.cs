using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GeoLab_5_17_AJAX.Models;

namespace GeoLab_5_17_AJAX.Controllers
{
    public class HomeController : Controller
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        // GET: Home
        public ActionResult Index()
        {
            return View(db.Student_5_17s.ToList());
        }
        public JsonResult Add(string Name)
        {
            try
            {
                Student_5_17 st = new Student_5_17() { StudentName = Name };
                db.Student_5_17s.InsertOnSubmit(st);
                db.SubmitChanges();

                return Json(st.Id);
            }
            catch (Exception ex)
            {
                return Json("false");
            }
        }
        public JsonResult Delete(string Id)
        {
            db.Student_5_17s.DeleteOnSubmit(db.Student_5_17s.Where(x => x.Id == Convert.ToInt32(Id)).FirstOrDefault());
            db.SubmitChanges();
            return Json("true");
        }
        public JsonResult AutoCompliteResult(string query)
        {
            List<Student_5_17> list = db.Student_5_17s.Where(x => x.StudentName.Contains(query.Trim())).ToList();

            return Json(list.Take(10), JsonRequestBehavior.AllowGet);
        }
    }
}