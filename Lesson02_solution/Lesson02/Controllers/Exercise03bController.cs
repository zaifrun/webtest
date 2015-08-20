using Lesson02.Models;
using System.Web.Mvc;

namespace Lesson02.Controllers
{
    public class Exercise03bController : Controller
    {
      

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection fc) {
            Dice dice1, dice2;

            // dice 1
            if (Session["dice1"] == null) {
                dice1 = new Dice();
                Session["dice1"] = dice1;
            }
            else {
                dice1 = (Dice)Session["dice1"];
            }

            // dice 2
            if (Session["dice2"] == null) {
                dice2 = new Dice();
                Session["dice2"] = dice2;
            }
            else {
                dice2 = (Dice)Session["dice2"];
            }

            if (fc["dice1"] != null) {
                dice1.Roll(); 
            }
            else if (fc["dice2"] != null) {
                dice2.Roll();
            }

            ViewBag.Dice1 = dice1;
            ViewBag.Dice2 = dice2;

            return View();
        }



    }
}
