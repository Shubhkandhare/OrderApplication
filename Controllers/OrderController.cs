﻿using System;
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
            if (id != 0)
                return View(viewname[0]);
            else
                return View();
        }

        public IActionResult PhysicalProduct()
        {
            string strPackagingSlip = "Your Payment is received and your shipping is ready.";
            ViewBag.PackagingSlip = strPackagingSlip;
            return View();
        }

        public IActionResult Books()
        {
            string strDuplicateCopyMessage = "This is duplicate copy for Royalty Department.";
            ViewBag.DuplicateCopyMessage = strDuplicateCopyMessage;
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
