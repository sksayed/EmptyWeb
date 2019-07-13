using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public JsonResult Index()
        {
            //now return a json file

            return Json(new { id = 1, name = "sayed" });
        }
    }
}
