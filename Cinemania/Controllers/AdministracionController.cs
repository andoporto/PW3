using Cinemania.Models;
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

        public object lPeli { get; private set; }

        // GET: Administracion/Inicio
        public ActionResult Inicio()
        {
            return View();
        }

        // GET: Administracion/Peliculas
        /*   public ActionResult Peliculas()
           {
               var listaPeliculas = db.Pelicula.ToList();

               return View(listaPeliculas);
           }
           */

        public ActionResult Peliculas()
        {
            var listaPeliculas = db.Peliculas.ToList();
            ViewBag.listaCalificaciones = new SelectList(db.Calificaciones, "IdCalificaciones", "Nombre");

            return View(listaPeliculas);
        }




        // GET: Peliculas/NuevoPelicula

        public ActionResult NuevoPelicula()
        {
             ViewBag.IdCalificacion = new SelectList(db.Calificaciones, "IdCalificacion", "Nombre");
<<<<<<< HEAD
             ViewBag.IdGenero = new SelectList(db.Generos, "IdGenero", "Nombre");

                        
            
            
            // return View(lPeli); 
=======
             ViewBag.IdGenero = new SelectList(db.Generos, "IdGenero", "Nombre");            
>>>>>>> 24015a67021261dbd545174a4500f470cdd3f8b9
            
            ViewBag.listaPeliculas = new SelectList(db.Peliculas, "IdPelicula", "Nombre"); 

            return View();

        } 
<<<<<<< HEAD
       
=======
 
>>>>>>> 24015a67021261dbd545174a4500f470cdd3f8b9
        
        [HttpPost]
        public ActionResult NuevoPelicula(Peliculas Pelicula)
        {
            Peliculas pel = new Peliculas();
            pel.Nombre = Pelicula.Nombre;
            pel.Descripcion = Pelicula.Descripcion;
            pel.Imagen = Pelicula.Imagen;
            pel.IdCalificacion = Pelicula.IdCalificacion;
            pel.IdGenero = Pelicula.IdGenero;
            pel.Duracion = Pelicula.Duracion;
            pel.FechaCarga = DateTime.Now;
           

            if (ModelState.IsValid)
            {
                
                
                
                db.Peliculas.Add(pel);
                db.SaveChanges();

                return RedirectToAction("Peliculas"); // Retorna a la vista "Peliculas"
            }
            return View();
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
            ViewBag.listaSedes = new SelectList(db.Sedes, "IdSede", "Nombre");
            return View();
        }

        [HttpPost]
        public ActionResult NuevoSede(Sedes Sede)
        {
            Sedes sed = new Sedes();
            sed.Nombre = Sede.Nombre;
            sed.Direccion = Sede.Direccion;
            sed.PrecioGeneral = Sede.PrecioGeneral;
            


            if (ModelState.IsValid)
            {

<<<<<<< HEAD


            db.Sedes.Add(sed);
            db.SaveChanges();

=======


                db.Sedes.Add(sed);
                db.SaveChanges();

>>>>>>> 24015a67021261dbd545174a4500f470cdd3f8b9
                return RedirectToAction("Sedes"); // Retorna a la vista "Sedes"
            }
            return View();
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
            sede.PrecioGeneral = Convert.ToDecimal(Request["PrecioGeneral"]);

            /** GENERA PROBLEMAS AL ACTUALIZAR**/
            db.SaveChanges();

            return RedirectToAction("Sedes");
        }



        public ActionResult Carteleras()
        {
<<<<<<< HEAD
            var listaCarteleras = db.Carteleras.ToList();          
=======
            var listaCarteleras = db.Carteleras.ToList();
           // ViewBag.listaCalificaciones = new SelectList(db.Calificaciones, "IdCalificaciones", "Nombre");
>>>>>>> 24015a67021261dbd545174a4500f470cdd3f8b9

            return View(listaCarteleras);
        }

         // GET: Administracion/Carteleras
        public ActionResult NuevoCartelera()
        {
            ViewBag.IdSede = new SelectList(db.Sedes, "IdSede", "Nombre");
            ViewBag.IdPelicula = new SelectList(db.Peliculas, "IdPelicula", "Nombre");
            ViewBag.IdVersion = new SelectList(db.Versiones, "IdVersion", "Nombre");
<<<<<<< HEAD
            return View();
        }
         [HttpPost]
        public ActionResult NuevoCartelera(Carteleras Cartelera)
        {
            Carteleras car = new Carteleras();
            car.IdSede = Cartelera.IdSede;
            car.IdPelicula = Cartelera.IdPelicula;
            car.HoraInicio = Cartelera.HoraInicio;
            car.Lunes = Cartelera.Lunes;
            car.Martes = Cartelera.Martes;
            car.Miercoles = Cartelera.Miercoles;
            car.Jueves = Cartelera.Jueves;
            car.Viernes = Cartelera.Viernes;
            car.Sabado = Cartelera.Sabado;
            car.Domingo = Cartelera.Domingo;
            car.FechaInicio = Cartelera.FechaInicio;
            car.FechaFin = Cartelera.FechaFin;
            car.NumeroSala = Cartelera.NumeroSala;
            car.IdVersion = Cartelera.IdVersion;

            if (ModelState.IsValid)
            {
                db.Carteleras.Add(car);
                db.SaveChanges();

                return RedirectToAction("Carteleras"); // Retorna a la vista "Peliculas"
            }
=======
>>>>>>> 24015a67021261dbd545174a4500f470cdd3f8b9
            return View();
        }
         [HttpPost]
        public ActionResult NuevoCartelera(Carteleras Cartelera)
        {
            Carteleras car = new Carteleras();
            car.IdSede = Cartelera.IdSede;
            car.IdPelicula = Cartelera.IdPelicula;
            car.HoraInicio = Cartelera.HoraInicio;
            car.Lunes = Cartelera.Lunes;
            car.Martes = Cartelera.Martes;
            car.Miercoles = Cartelera.Miercoles;
            car.Jueves = Cartelera.Jueves;
            car.Viernes = Cartelera.Viernes;
            car.Sabado = Cartelera.Sabado;
            car.Domingo = Cartelera.Domingo;
            car.FechaInicio = Cartelera.FechaInicio;
            car.FechaFin = Cartelera.FechaFin;
            car.NumeroSala = Cartelera.NumeroSala;
            car.IdVersion = Cartelera.IdVersion;

            if (ModelState.IsValid)
            {
                db.Carteleras.Add(car);
                db.SaveChanges();

<<<<<<< HEAD
        // GET: Administracion/Reportes      
=======
                return RedirectToAction("Carteleras"); // Retorna a la vista "Peliculas"
            }
            return View();
        }
>>>>>>> 24015a67021261dbd545174a4500f470cdd3f8b9

        public ActionResult Reportes()
        {
            var listaReservas = db.Reservas.ToList();

            return View(listaReservas);
        }

        // GET: Administracion/Reporte
        public ActionResult NuevoReporte()
        {
            ViewBag.IdSede = new SelectList(db.Sedes, "IdSede", "Nombre");            
            ViewBag.IdVersion = new SelectList(db.Versiones, "IdVersion", "Nombre");
            ViewBag.IdPelicula = new SelectList(db.Peliculas, "IdPelicula", "Nombre");
            return View();
        }
        [HttpPost]
        public ActionResult NuevoReporte(Reservas Reserva)
        {
            Reservas res = new Reservas();
            res.IdSede = Reserva.IdSede;
            res.IdVersion = Reserva.IdVersion;
            res.IdPelicula = Reserva.IdPelicula;
         
           

            if (ModelState.IsValid)
            {
                db.Reservas.Add(res);
                db.SaveChanges();

                return RedirectToAction("Carteleras"); // Retorna a la vista "Peliculas"
            }
            return View();
        }
    }
}