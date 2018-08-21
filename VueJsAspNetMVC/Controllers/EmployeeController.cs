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

        public ActionResult GetAll()
        {
            List<Employee> employees = DB.Employees;
            return Json(employees);
        }

        public ActionResult Get(int ID = 0)
        {
            Employee employee = ID > 0 ? new Employee().Get(ID) : new Employee();
            return Json(employee);
        }

        public JsonResult ReadCountries()
        {
            return Json(new Countries().Get());
        }

        public ActionResult ReadStates(string Country)//TODO: Filter by country
        {
            return Json(Enumerable.Range(0, 50).Select(x => "State " + x.ToString()));
        }

        public ActionResult Save(Employee Item)
        {
            Item.Save();
            return Json(Item);
        }
    }
}