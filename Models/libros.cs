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
        //Cantidad Hoj
        public int cantidad_hoj {get; set;}
        //Alto
        public double alto {get; set;}
        //Ancho
        public double ancho {get; set;}
        //CD
        public bool CD {get; set;}
        //Idioma
        public string idioma {get; set;}
        //Portada
        public byte portada {get; set;}
        //Sipnosis
        public string sipnosis {get; set;}
        //Estado de Libro
        public string estado_libro {get; set;}
    }
}
