using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrderApplication.Models;

namespace OrderApplication.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index(int id)
        {
            PaymentTypesCollection paymentType = new PaymentTypesCollection();
            var viewname = paymentType.paymentTypes.Where(p => p.Id == id).Select(p => p.PaymentType).ToArray();
            return View(viewname[0]);
        }

        public IActionResult PhysicalProduct()
        {
            string strPackagingSlip = "Your Payment is received and your shipping is ready.";
            ViewBag.PackagingSlip = strPackagingSlip;
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
