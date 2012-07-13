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
    public class EquiposController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /Equipos/

        public ViewResult Index()
        {
            return View(db.Equipos.ToList());
        }

        //
        // GET: /Equipos/Details/5

        public ViewResult Details(decimal id)
        {
            Equipos equipos = db.Equipos.Find(id);
            return View(equipos);
        }

        public ViewResult MostrarEquipo(decimal id)
        {
            Equipos equipos = db.Equipos.Find(id);
            return View(equipos);
        }

        //
        // GET: /Equipos/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Equipos/Create

        [HttpPost]
        public ActionResult Create(Equipos equipos)
        {
            if (ModelState.IsValid)
            {
                db.Equipos.Add(equipos);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(equipos);
        }
        
        //
        // GET: /Equipos/Edit/5
 
        public ActionResult Edit(decimal id)
        {
            Equipos equipos = db.Equipos.Find(id);
            return View(equipos);
        }

        //
        // POST: /Equipos/Edit/5

        [HttpPost]
        public ActionResult Edit(Equipos equipos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(equipos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(equipos);
        }

        //
        // GET: /Equipos/Delete/5
 
        public ActionResult Delete(decimal id)
        {
            Equipos equipos = db.Equipos.Find(id);
            return View(equipos);
        }

        //
        // POST: /Equipos/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(decimal id)
        {            
            Equipos equipos = db.Equipos.Find(id);
            db.Equipos.Remove(equipos);
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