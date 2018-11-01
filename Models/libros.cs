namespace Biblioteca.Models
{
    public class libros
    {
        [Key]
        public int cod_lib {get; set;}
        [Required]
        public string ISBN {get; set;}
        public string categoria {get; set;}
        public string titulo {get; set;}
        public string autor {get; set;}
        public string editorial {get; set;}
        public int cantidad_lib {get; set;}
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
