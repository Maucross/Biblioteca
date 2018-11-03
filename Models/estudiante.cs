using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Biblioteca.Models
{
    public class estudiante
    {
        //public int tipoU {get; set;} //tipo1 = bibliotecario, tipo2 = estudiante 
        [Key]
        public int cod_est{get; set;}

        [Required(ErrorMessage = "Error en el usuario o contrasena")]
        public string usuario {get; set;}

        [Required(ErrorMessage = "Error en el usuario o contrasena")]
        public string contraseña {get; set;}
        
        //Nombre
        public string nomb {get; set;}
        //Apellido
        public string ape {get; set;}
        //Escuela
        public string escuela {get; set;}
    }
}
