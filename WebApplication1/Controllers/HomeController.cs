using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository employeeRepository;
        public HomeController(IEmployeeRepository repository)
        {
            this.employeeRepository = repository;
        }
        public JsonResult Index()
        {
            //now return a json file

            return Json(new { id = 1, name = "sayed" });
        }

        public JsonResult Get(int id )
        {
            return Json(this.employeeRepository.GetEmployee(id));
        }
    }
}
