using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models
{
    public class reserva
    {
        [Key]
        public int cod_res {get; set;}
        public int cod_prest {get; set;}
        [Required]
        public DateTime fecha_realizacion {get; set;}
        public string estado_reserva {get; set;}
        public prestamo datosprestamo {get; set;}
    }
}
