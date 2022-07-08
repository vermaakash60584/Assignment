using System;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Assignment.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            List<Employee> employeeList = new List<Employee>
            {
                new Employee {EId=1,EName="Akash Verma",EDesignation="Progammer Analyst",EDOJ=DateTime.Parse("2022-02-12")},
                new Employee {EId=2,EName="Owen Norris",EDesignation="Consultant",EDOJ=DateTime.Parse("2021-04-15")},
                new Employee {EId=3,EName="Lara Carrillo",EDesignation="Tester",EDOJ=DateTime.Parse("2020-10-29")},
                new Employee {EId=4,EName="Nora Mcclain",EDesignation="System Engineer",EDOJ=DateTime.Parse("2015-12-10")},
                new Employee {EId=5,EName="Dan Hall",EDesignation="Trainee Engineer",EDOJ=DateTime.Parse("2021-07-06")}
            };

            return View(employeeList);
        }
    }
}
