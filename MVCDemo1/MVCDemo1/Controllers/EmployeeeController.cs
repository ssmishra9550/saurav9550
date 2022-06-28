using BusinessLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo1.Controllers
{
    public class EmployeeeController : Controller
    {
        // GET: Employeee
        public ActionResult Index()
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            List<Employee1> employees = employeeBusinessLayer.Employees.ToList();
            return View(employees);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
    }
} 