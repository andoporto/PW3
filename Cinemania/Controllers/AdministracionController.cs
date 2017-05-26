using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cinemania.Controllers
{
    public class AdministracionController : Controller
    {
        // GET: Administracion/Inicio
        public ActionResult Inicio()
        {
            return View();
        }

        // GET: Administracion/Peliculas
        public ActionResult Peliculas()
        {
            return View();
        }

        // GET: Administracion/Carteleras
        public ActionResult Carteleras()
        {
            return View();
        }

        // GET: Administracion/Sedes
        public ActionResult Sedes()
        {
            return View();
        }

        // GET: Administracion/Reportes
        public ActionResult Reportes()
        {
            return View();
        }
    }
}