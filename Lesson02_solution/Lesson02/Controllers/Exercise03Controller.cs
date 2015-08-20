using Lesson02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson02.Controllers
{
    public class Exercise03Controller : Controller
    {
        //
        // GET: /Exercise03/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection fc) {
            Dice dice;
            if (Session["dice"] == null) {

                dice = new Dice();
                dice.Roll();
                Session["dice"] = dice;
            }
            else {
                dice = (Dice)Session["dice"];
                dice.Roll();
            }

            ViewBag.Dice = dice;

            return View();
        }



    }
}
