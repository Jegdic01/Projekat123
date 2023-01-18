using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projekat123.Controllers
{
    public class SiteController : Controller
    {
        // GET: Site
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult Services()
        {
            return View();
        }

        public ActionResult Concat()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Komentar() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult Komentar(Models.Forma forma)
        {
            return View("Rezultat", forma);
        }
    }
}