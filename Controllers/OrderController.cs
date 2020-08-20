using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OrderApplication.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PhysicalProduct()
        {
            return View();
        }

        public IActionResult Books()
        {
            return View();
        }

        public IActionResult Video()
        {
            return View();
        }

        public IActionResult Membership()
        {
            return View();
        }
    }
}
