using Lesson02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson02.Controllers
{
    public class Exercise01Controller : Controller
    {
        public ActionResult Index()
        {
            // create a new product object with instance name glass
            Product glass = new Product("Wine glass", 160.50);
            glass.ImageUrl = "grandcru.jpg";
            glass.Manufacturer = "Rosendahl";
            ViewBag.Glass = glass;
            
            Product bin = new Product("Kitchen Garbage", 425.00, "bin_35l.jpg", "Unknown");
            ViewBag.Bin= bin;

            Product knife = new Product("Knife", 154.50, "st_knife.jpg", "Steelline");
           
            ViewBag.Knife = knife;
           

            return View();
        }
    }

}
