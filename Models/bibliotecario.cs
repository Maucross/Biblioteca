using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models
{
    public class bibliotecario
    {
        
        //public int tipoU {get; set;} //tipo1 = bibliotecario, tipo2 = estudiante 
        [Key]
        public int id_bib {get; set;}
        
        [Required(ErrorMessage = "Error en el usuario o contrasena")]
        public string usuario {get; set;}
        [Required(ErrorMessage = "Error en el usuario o contrasena")]
        public string contraseña {get; set;}
    }
}
