using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VueJsAspNetMVC.Models;

namespace VueJsAspNetMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Get()
        {
            List<Employee> employees = DB.Employees;
            return Json(employees);
        }

        public ActionResult Edit(int ID = 0)
        {
            Employee employee = ID > 0 ? new Employee().Get(ID) : new Employee();
            return View(employee);
        }

        public JsonResult Save(Employee Item)
        {
            Item.Save();
            return Json(Item);
        }
    }
}