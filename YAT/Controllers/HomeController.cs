using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YAT.Models;

namespace YAT.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Cerdas()
        {
            return View();
        }

        public ActionResult Sehat()
        {
            return View();
        }

        public ActionResult Sosial()
        {
            return View();
        }

        public ActionResult Wakaf()
        {
            return View();
        }

        public ActionResult Qurban()
        {
            return View();
        }

        public ActionResult Liputan()
        {
            return View();
        }

        public ActionResult Inspirasi()
        {
            return View();
        }

        public ActionResult VisiMisi()
        {
            return View();
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
