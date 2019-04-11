using Employee.DB;
using Employee.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employee.MVC.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeRepository repository = null;
        public EmployeeController()
        {
            repository = new EmployeeRepository();
        }
        [HttpGet]
        public ActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddEmployee(EmployeeModel model)
        {
            bool status = false;
            string message = " ";

            if (ModelState.IsValid)
            {
                var ID = repository.EmployeeAdd(model);
                if (ID > 0)
                {
                    ModelState.Clear();
                    message = "Reginstration Complete!";
                }
                status = true;
                return RedirectToAction("AddEmployee");
            }
            else
            {
                message = "Invalid Request!" ;
            }

            ViewBag.Status = status;
            ViewBag.Message = message;
            return View(model);
        }
    }
}