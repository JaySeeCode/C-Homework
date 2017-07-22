using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace mvcTest.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            ViewData["First Name"] = "Juan Carlos";
            ViewData["Last Name"] = "Gonzalez";
            return View();
        }

        public IActionResult About()
        {
            ViewData["AppName"] = "A simple application to show us how to do the server side things we do in Node.js (routing, rendering, etc), but in C#";
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}