using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cinemania.Controllers
{
    public class AdministracionController : Controller
    {
        // BASE DE DATOS
        Context db = new Context();

        // GET: Administracion/Inicio
        public ActionResult Inicio()
        {
            return View();
        }

        // GET: Administracion/Peliculas
        public ActionResult Peliculas()
        {
            var listaPeliculas = db.Peliculas.ToList();

            return View(listaPeliculas);
        }

        // GET: Peliculas/NuevoPelicula
        public ActionResult NuevoPelicula()
        {
            ViewBag.IdCalificacion = new SelectList(db.Calificaciones, "IdCalificacion", "Nombre");
            ViewBag.IdGenero = new SelectList(db.Generos, "IdGenero", "Nombre");
            return View();
        }

        [HttpPost]
        public ActionResult NuevoPelicula(FormCollection form)
        {
            Context ctx = new Context();
            Peliculas pel = new Peliculas();

            pel.Nombre = form["nombre"];
            pel.Descripcion = form["descripcion"];
            pel.IdCalificacion = Convert.ToInt32(form["IdCalificacion"]);
            pel.IdGenero = Convert.ToInt32(form["IdGenero"]);
            pel.Imagen = form["imagen"];
            pel.Duracion = Convert.ToInt16(form["duracion"]);
            pel.FechaCarga = DateTime.Now;

            ctx.Peliculas.Add(pel);
            ctx.SaveChanges();

            return RedirectToAction("Peliculas"); // Retorna a la vista "Peliculas"
        }

        //GET: Peliculas/EditarPelicula
        public ActionResult EditarPelicula(int IdPelicula)
        {
            /*** SINTAXIS DE METODO ***/
            var pel = db.Peliculas.Where(p => p.IdPelicula == IdPelicula).FirstOrDefault();
            ViewBag.IdCalificacion = new SelectList(db.Calificaciones, "IdCalificacion", "Nombre");
            ViewBag.IdGenero = new SelectList(db.Generos, "IdGenero", "Nombre");

            return View(pel);
        }

        [HttpPost]
        public ActionResult EditarPelicula(Peliculas pel, int IdPelicula)
        {
            // SINTAXIS DE METODO
            var peli = db.Peliculas.Where(p => p.IdPelicula == IdPelicula).FirstOrDefault();

            peli.Nombre = Request["nombre"];
            peli.Descripcion = Request["descripcion"];
            peli.IdCalificacion = Convert.ToInt32(Request["IdCalificacion"]);
            peli.IdGenero = Convert.ToInt32(Request["IdGenero"]);
            peli.Imagen = Request["imagen"];
            peli.Duracion = Convert.ToInt32(Request["duracion"]);
            pel.FechaCarga = DateTime.Now;

            db.SaveChanges();

            return RedirectToAction("Peliculas");
        }

        // GET: Administracion/Sedes
        public ActionResult Sedes()
        {
            var listaSedes = db.Sedes.ToList();

            return View(listaSedes);
        }

        // GET: Sedes/NuevoSede
        public ActionResult NuevoSede()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NuevoSede(FormCollection form)
        {
            Context ctx = new Context();
            Sedes sede = new Sedes();

            sede.Nombre = form["Nombre"];
            sede.Direccion = form["Direccion"];
            sede.PrecioGeneral = Convert.ToInt32(form["PrecioGeneral"]);

            ctx.Sedes.Add(sede);
            ctx.SaveChanges();

            return RedirectToAction("Sedes"); // Retorna a la vista "Sedes"
        }

        //GET: Sedes/EditarSede
        public ActionResult EditarSede(int IdSede)
        {
            /*** SINTAXIS DE METODO ***/
            var sede = db.Sedes.Where(s => s.IdSede == IdSede).FirstOrDefault();

            return View(sede);
        }

        [HttpPost]
        public ActionResult EditarSede(Sedes sed, int IdSede)
        {
            // SINTAXIS DE METODO
            var sede = db.Sedes.Where(s => s.IdSede == IdSede).FirstOrDefault();

            sede.Nombre = Request["Nombre"];
            sede.Direccion = Request["Direccion"];
            sede.PrecioGeneral = Convert.ToInt32(Request["PrecioGeneral"]);

            /** GENERA PROBLEMAS AL ACTUALIZAR**/
            db.SaveChanges();

            return RedirectToAction("Sedes");
        }




        // GET: Administracion/Carteleras
        public ActionResult Carteleras()
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