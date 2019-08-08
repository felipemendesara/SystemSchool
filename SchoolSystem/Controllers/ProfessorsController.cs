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
    public class ProfessorsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Professors
        // Entity Framework retorna todos os professores
        public ActionResult Index()
        {
            return View(db.Professores.ToList());
        }
        // Adiciona os professores
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdProfessor,NomeProfessor")] Professor professor)
        {
            if (ModelState.IsValid)
            {
                db.Professores.Add(professor);
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
