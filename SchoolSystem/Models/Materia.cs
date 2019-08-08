using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolSystem.Models
{
    public class Materia
    {
        [Key]
        [ScaffoldColumn(false)]
        [Display(Name = "Código")]
        public int IdMateria { get; set; }
        [Required]
        [Display(Name = "Nome")]
        public string NomeMateria { get; set; }
    }
}