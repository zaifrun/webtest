using Lesson02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson02.Controllers
{
    public class Exercise02Controller : Controller
    {
        public ActionResult Index() {

            Person brother = new Person("Ken", "Thompson", "Byagervej 17", "9000", "Aalborg");
            brother.AddPhone("1218 2419");
            brother.AddPhone("2234 4518");
            brother.Birthday = new DateTime(1987, 4, 6);
            ViewBag.Brother = brother;

            Person sister = new Person("Kirstein", "Roth", "Vibevej 22", "8300", "Odder");
            sister.AddPhone("2214 2818");
            sister.AddPhone("1230 4956");
            sister.Birthday = new DateTime(1982, 12, 12);
            ViewBag.Sister = sister;

            return View();
        }
    }
}
