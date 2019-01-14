using LabJJ2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabJJ2.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Edit(Products model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }

            return View("Index", model);
        }
    }
}