using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models
{
    public class prestamo
    {
        [Key]
        //Código de Préstamo
        public int cod_prest {get; set;}
        //Código del Libro
        public int cod_lib {get; set;}
        [Required(ErrorMessage = "Ingresar modalidad")]
        public string modalidad {get; set;}
        [Required(ErrorMessage = "Ingresar fecha de reserva")]

        public DateTime fecha_reserva {get; set;}
        public estudiante datosEstudiante {get; set;}
        public libros datosLibro {get; set;}
    }
}
