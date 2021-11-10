using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()   // This is a method
        {
            return View();
        }
    }
}
