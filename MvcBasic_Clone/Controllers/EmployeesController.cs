using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBasic_Clone.Models;

namespace MvcBasic_Clone.Controllers
{
    public class EmployeesController : Controller
    {
        private HRContext db = new HRContext();
        // GET: Employees
        public ActionResult Index()
        {
            var emps = db.Employees.ToList();
            return View(emps);
        }

        public ActionResult EmployeeList()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id=10001,Name="David",Phone="0933-154228",Email="david@gmail.com"},
            new Employee { Id = 10001, Name = "Davi", Phone = "0933-154228", Email = "david@gmail.com" },
            new Employee { Id = 10001, Name = "Dav", Phone = "0933-154228", Email = "david@gmail.com" },
            new Employee { Id = 10001, Name = "Da", Phone = "0933-154228", Email = "david@gmail.com" },
            new Employee { Id = 10001, Name = "D", Phone = "0933-154228", Email = "david@gmail.com" }
            };
            
            

            return View(employees);
        }
    }
}