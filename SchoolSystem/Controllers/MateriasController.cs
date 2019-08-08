using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SchoolSystem.Models;

namespace SchoolSystem.Controllers
{
    public class MateriasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Materias
        // Entity Framework, retorna todas as matérias
        public ActionResult Index()
        {
            return View(db.Materias.ToList());
        }
        // Adiciona a matéria
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdMateria,NomeMateria")] Materia materia)
        {
            if (ModelState.IsValid)
            {
                db.Materias.Add(materia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
