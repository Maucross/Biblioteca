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
        [Required]
        //Modalidad
        public string modalidad {get; set;}
        //Fecha de Reserva
        public DateTime fecha_reserva {get; set;}
    }
}
