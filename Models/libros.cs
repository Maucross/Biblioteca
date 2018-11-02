using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Biblioteca.Models
{
    public class libros
    {
        [Key]
        //Código de Libro
        public int cod_lib {get; set;}
        [Required]
        //ISBN
        public string ISBN {get; set;}
        //Categoría
        public string categoria {get; set;}
        //Título
        public string titulo {get; set;}
        //Autor
        public string autor {get; set;}
        //Editorial
        public string editorial {get; set;}
        //Cantidad Libros
        public int cantidad_lib {get; set;}
        //Año Pub
        public int año_pub {get; set;}
        public int cantidad_hoj {get; set;}
        public double alto {get; set;}
        public double ancho {get; set;}
        public bool CD {get; set;}
        public string idioma {get; set;}
        public byte portada {get; set;}
        public string sipnosis {get; set;}
        public string estado_libro {get; set;}
    }
}
