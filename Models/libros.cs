using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Biblioteca.Models
{
    public class libros
    {
        [Key]
        public int cod_lib {get; set;}
        [Required(ErrorMessage = "Ingresar ISBN")]
        public string ISBN {get; set;}
        [Required(ErrorMessage = "Ingresar categoria")]
        public string categoria {get; set;}
        [Required(ErrorMessage = "Ingresar titulo")]
        public string titulo {get; set;}
        [Required(ErrorMessage = "Ingresar autor")]
        public string autor {get; set;}
        [Required(ErrorMessage = "Ingresar editorial")]
        public string editorial {get; set;}
        [Required(ErrorMessage = "Ingresar cantidad de libros")]
        public int cantidad_lib {get; set;}
        [Required(ErrorMessage = "Ingresar año de publicación")]
        public int año_pub {get; set;}
        [Required(ErrorMessage = "Ingresar cantidad de hojas")]
        public int cantidad_hoj {get; set;}
        [Required(ErrorMessage = "Ingresar altura del libro")]
        public double alto {get; set;}
        [Required(ErrorMessage = "Ingresar anchura del ibro")]
        public double ancho {get; set;}
        [Required(ErrorMessage = "Ingresar si tiene CD")]
        public bool CD {get; set;}
        [Required(ErrorMessage = "Ingresar idioma")]  
        public string idioma {get; set;}
        
        public byte? portada {get; set;}
        [Required(ErrorMessage = "Ingresar sipnosis")]
        public string sipnosis {get; set;}
        
        public string estado_libro {get; set;}
    }
}
