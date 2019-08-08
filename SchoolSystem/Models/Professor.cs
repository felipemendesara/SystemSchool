using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolSystem.Models
{
    public class Professor
    {
        [Key]
        [ScaffoldColumn(false)]
        [Display(Name = "Código")]
        public int IdProfessor { get; set; }
        [Required]
        [Display(Name = "Nome")]
        public string NomeProfessor { get; set; }
    }
}