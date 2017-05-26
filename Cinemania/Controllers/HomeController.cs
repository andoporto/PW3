using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cinemania.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home/Inicio
        public ActionResult Inicio()
        {
            return View();
        }

        // GET: Home/Login
        public ActionResult Login()
        {
            return View();
        }

    }
}