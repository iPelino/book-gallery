using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookGallery.Controllers
{
    public class BooksController : Controller
    {
        public ActionResult Detail()
        {
            /*if (DateTime.Today.DayOfWeek == DayOfWeek.Wednesday)
            {
                return Redirect("/");
            }

            return Content("Hello from Detail");*/


            ViewBag.SetTitle = "Mr. Mercedes";
            ViewBag.ReleaseYear = "2015";
            ViewBag.Description = "Another thriller from Stephen King";
            ViewBag.Authors = new string[]
            {
                "Stephen King"
            };


            return View();

        }
    }
}