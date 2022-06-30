using BusinessLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUsingBusinessObjest.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            List<Employee> employees = employeeBusinessLayer.Employees.ToList();
            return View(employees);          
        }
        [ActionName("Create")]
        public ActionResult Create_Get()
        {
            return View();
        }


        //----****** This Is the 1st Way to insert data into database using ***** FORMCOLLETION ***** (Kudvenkat video 13 to 14 ) --------------**************

        //public ActionResult Create(FormCollection formCollection)
        //{
        //    Employee employee = new Employee();
        //    employee.EmployeeName = formCollection["EmployeeName"];
        //    employee.Gender = formCollection["Gender"];
        //    employee.City = formCollection["City"];
        //    employee.DepartmentId = Convert.ToInt32(formCollection["DepartmentId"]);

        //    EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
        //    employeeBusinessLayer.AddEmployee(employee);
        //    return RedirectToAction("Index");          
        //}


//----****** This Is the 2nd Way to insert data into database using ***** UpdateModel ***** (Kudvenkat video 14 to 15) --------------**************

        //[HttpPost]
        //[ActionName("Create")]
        //public ActionResult Create_Post()
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Employee employee = new Employee();
        //        UpdateModel(employee);
        //        EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
        //        employeeBusinessLayer.AddEmployee(employee);
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}

 //----****** This Is the 3rd Way to insert data into database using ***** TryUpdateModel ***** (Kudvenkat video 14 to 15) --------------**************

        //[HttpPost]
        //[ActionName("Create")]
        //public ActionResult Create_Post()
        //{
        //    Employee employee = new Employee();
        //    TryUpdateModel(employee);
        //    if (ModelState.IsValid)
        //    {
        //        EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
        //        employeeBusinessLayer.AddEmployee(employee);
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}


 //----****** This Is the 3rd Way to insert data into database using ***** TryUpdateModel ***** (Kudvenkat video 14 to 15) --------------**************

        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post(Employee employee)
        {
           
            if (ModelState.IsValid)
            {
                EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
                employeeBusinessLayer.AddEmployee(employee);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            Employee employee = employeeBusinessLayer.Employees.Single(empId => empId.Id == id);
            return View(employee);
        }

        // ************************************* Below this code my system can be hack with the help of Fiddler *******************
        // ************************ So I am using another approach **********************************
        //[HttpPost]
        //public ActionResult Edit(Employee employee)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
        //        employeeBusinessLayer.UpdateEmployee(employee);
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}

        //[HttpPost]
        //[ActionName("Edit")]
        //public ActionResult Edit_Post( int Id)
        //{
        //    EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
        //    Employee employee = employeeBusinessLayer.Employees.Single(x => x.Id == Id);
        //    UpdateModel(employee, new string[] { "Id", "Gender", "City", "DepartmentId" });
        //    if (ModelState.IsValid)
        //    {
        //        employeeBusinessLayer.UpdateEmployee(employee);
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}

//*************** Including and Excluding from Model Binding using Interface ******************************
        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit_Post(int id)
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            Employee employee = employeeBusinessLayer.Employees.Single(x => x.Id == id);
            UpdateModel<IEmployee>(employee);
            if (ModelState.IsValid)
            {
                employeeBusinessLayer.UpdateEmployee(employee);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Delete(int Id)
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            employeeBusinessLayer.DeleteEmployee(Id);
            return RedirectToAction("Index");
        }
        
    }

}