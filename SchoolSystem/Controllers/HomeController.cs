using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolSystem.Repositorio;

namespace SchoolSystem.Controllers
{

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Lista os professores
            var listaProfessores = RepositoryCursosProfessores.ListaProfessores();

            // Lista as matérias
            var listaMaterias = RepositoryCursosProfessores.ListaMaterias();

            // Lista e vincula materia com professor
            var listaMateriasProfessor = RepositoryCursosProfessores.ListaMateriaProfessor();

            ViewBag.ListaProfessor = listaProfessores;
            ViewBag.ListaMaterias = listaMaterias;
            ViewBag.ListaMateriasProfessor = listaMateriasProfessor;

            return View();
        }

        [HttpPost]
        public ActionResult VincularValores(int idProfessor, int idMateria)
        {

            // Vincula professor com matéria por id

            RepositoryCursosProfessores.VinculaValores(idProfessor, idMateria);

            return RedirectToAction("Index");
        }

    }
}