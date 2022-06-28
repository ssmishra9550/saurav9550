using MVCDemo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index( int departmentId)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<Employee> employees = employeeContext.employees.Where(emp => emp.DepartmentId == departmentId).ToList() ;
            return View(employees);
        }
        public ActionResult Details(int Id)
        {  
            EmployeeContext employeeContext = new EmployeeContext();
            Employee employee = employeeContext.employees.Single(emp => emp.Id == Id);
            return View(employee);
        }
    }
}