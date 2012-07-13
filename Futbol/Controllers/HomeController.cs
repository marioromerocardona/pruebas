using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using Futbol.Models;


namespace Futbol.Controllers
{
    public class HomeController : Controller
    {
        private Entities db = new Entities();

        public ActionResult Index()
        {
            ViewBag.Message = "Clasificación:";
            var equipos = db.Clasificacion.Include("EQUIPOS")
                            .Where(e => e.EQUIPOS.ID == e.EQUIPO)
                            .OrderBy(e => e.POSICION);

            return View(equipos.ToList());
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
