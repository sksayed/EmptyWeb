using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeRepository employeeRepository;
        public EmployeeController(IEmployeeRepository employee)
        {
            this.employeeRepository = employee;
        }

        public ViewResult Index()
        {
            return View();
        }
        public ViewResult AbsolutePath()
        {
            return View("~/MyTest/MyTest.cshtml");
        }
        public ViewResult RelativePath ()
        {
            return View("../../MyTest/MyTest");
        }
    }
}
