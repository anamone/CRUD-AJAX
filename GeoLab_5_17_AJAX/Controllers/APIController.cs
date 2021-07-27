using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GeoLab_5_17_AJAX.Models;

namespace GeoLab_5_17_AJAX.Controllers
{
    public class APIController : Controller
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        // GET: API
        public JsonResult getUser()
        {
            return Json(db.Student_5_17s.ToList(),JsonRequestBehavior.AllowGet);
        }
        public JsonResult getSingleUser(int id)
        {
            return Json(db.Student_5_17s.Where(x => x.Id == id).FirstOrDefault(),JsonRequestBehavior.AllowGet);
        }
    }
}