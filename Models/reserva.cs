using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models
{
    public class reserva
    {
        [Key]
        //Código de Reserva
        public int cod_res {get; set;}
        //Código de Préstamo
        public int cod_prest {get; set;}
        [Required]
        //Fecha de Realización
        public DateTime fecha_realizacion {get; set;}
        //Estado de Reserva
        public string estado_reserva {get; set;}
        public prestamo datosprestamo {get; set;}
    }
}
