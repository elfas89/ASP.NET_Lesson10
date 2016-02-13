using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson10ASP.Controllers
{
    public class PartialController : Controller
    {
        // GET: Partial
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult Partial()
        {
            ViewBag.mess = " вью бэг частичное представление 1";
            return PartialView();
        }

    }
}