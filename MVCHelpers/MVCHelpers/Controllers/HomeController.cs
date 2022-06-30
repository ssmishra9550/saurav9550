using MVCHelpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHelpers.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            CRMEntities db = new CRMEntities();
            ViewBag.Dept = new SelectList(db.Departments, "Id", "DepartmentName");
            return View();
        }
    }
}