using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GeoLab_5_17_AJAX.Models;

namespace GeoLab_5_17_AJAX.Controllers
{
    public class AccountController : Controller
    {
        DataClasses1DataContext db = null;
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Get(studentInfo st)
        {
            if (db == null)
            {
                db = new DataClasses1DataContext();
            }
            db.Student_5_17s.InsertOnSubmit(new Student_5_17()
            {
                StudentName = st.StudentName
            });
            db.SubmitChanges();

            return Json("ჩაწერილია",JsonRequestBehavior.AllowGet);
        }
    }
}