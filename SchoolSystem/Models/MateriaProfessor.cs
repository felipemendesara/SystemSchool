using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolSystem.Models
{
    public class MateriaProfessor
    {

        public int IdMateriasProfessores { get; set; }

        public int FkMateria { get; set; }

        public int FkProfessor { get; set; }

        public string NomeMateria { get; set; }

        public string NomeProfessor { get; set; }
    }
}