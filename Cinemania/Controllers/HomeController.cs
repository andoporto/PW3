using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cinemania.Controllers
{
    public class HomeController : Controller
    {

        // BASE DE DATOS
        Context db = new Context();

        // GET: Home/Inicio
        public ActionResult Inicio()
        {

            var listaPeliculas = db.Peliculas.ToList();

            return View(listaPeliculas);
        }

        // GET: Home/Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ValidarLogin(FormCollection form)
        {
            /*** SINTAXIS DE CONSULTA ***/
            var emp = (from u in db.Usuarios
                       where u.NombreUsuario == form["nomUsuario"] && u.NombreUsuario == form["passUsuario"]
                       select u);

            /** FALTA IMPLEMENTAR VALIDACION **/

            return RedirectToAction("../Administracion/Inicio");          
        }



    }
}