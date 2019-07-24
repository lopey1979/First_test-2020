using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentExample.Models;

namespace StudentExample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //DateTime dt = DateTime.Now;

            //ViewBag.M1 = "This is the time" + dt.ToShortTimeString();

            ViewBag.M1 = "Hello from Pete at 12:00";
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Sarah Ferrand's design page";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Sarah Ferrand's design page";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
