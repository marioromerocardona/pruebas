using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Futbol.Models;

namespace Futbol.Controllers
{ 
    public class JugadoresController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /Jugadores/

        public ViewResult Index()
        {
            var jugadores = db.Jugadores.Include("EQUIPOS")
                            .Where(e => e.EQUIPOS.ID == e.EQUIPO)
                            .OrderBy(e => e.EQUIPOS.NOMBRE);

            return View(jugadores.ToList());
        }

        public ViewResult MostrarPorEquipo(int id) 
        {
            var jugadores = db.Jugadores.Include("EQUIPOS")
                          .Where(e => e.EQUIPOS.ID == id);

            return View(jugadores.ToList());          
        }
        //
        // GET: /Jugadores/Details/5

        public ViewResult Details(int id)
        {
            Jugadores jugadores = db.Jugadores.Find(id);
            return View(jugadores);
        }

        //
        // GET: /Jugadores/Create

        public ActionResult Create()
        {
            ViewBag.Equipos = new SelectList(db.Equipos.OrderBy(e => e.NOMBRE), "ID", "NOMBRE", String.Empty);
            return View();
        } 

        //
        // POST: /Jugadores/Create

        [HttpPost]
        public ActionResult Create(Jugadores jugadores)
        {
            if (ModelState.IsValid)
            {
                db.Jugadores.Add(jugadores);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }
            ViewBag.Equipos = new SelectList(db.Equipos.OrderBy(e => e.NOMBRE), "ID", "NOMBRE", jugadores.EQUIPO);
            return View(jugadores);
        }
        
        //
        // GET: /Jugadores/Edit/5
 
        public ActionResult Edit(int id)
        {
            Jugadores jugadores = db.Jugadores.Find(id);

            ViewBag.Equipos = new SelectList(db.Equipos.OrderBy(e => e.NOMBRE), "ID", "NOMBRE", jugadores.EQUIPO);

            return View(jugadores);
        }

        //
        // POST: /Jugadores/Edit/5

        [HttpPost]
        public ActionResult Edit(Jugadores jugadores)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jugadores).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Equipos = new SelectList(db.Equipos.OrderBy(e => e.NOMBRE), "ID", "NOMBRE", jugadores.EQUIPO);
            return View(jugadores);
        }

        //
        // GET: /Jugadores/Delete/5
 
        public ActionResult Delete(int id)
        {
            Jugadores jugadores = db.Jugadores.Find(id);
            return View(jugadores);
        }

        //
        // POST: /Jugadores/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Jugadores jugadores = db.Jugadores.Find(id);
            db.Jugadores.Remove(jugadores);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}