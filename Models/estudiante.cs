using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Biblioteca.Models
{
    public class estudiante
    {
        [Key]
        public int cod_est{get; set;}
        [Required]
        public string usuario {get; set;}
        
        public string contraseña {get; set;}
        public string nomb {get; set;}
        public string ape {get; set;}
        public string escuela {get; set;}
    }
}
