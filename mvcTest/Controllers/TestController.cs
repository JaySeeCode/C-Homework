using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace mvcTest.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index(string name, string userName = "Guest")
        {
            ViewData["My Name"] = name;
            ViewData["userName"] = userName;
            return View();
        }

        public IActionResult AboutMe()
        {
            return View();
        }
    }
}