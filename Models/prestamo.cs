using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models
{
    public class prestamo
    {
        [Key]
        public int cod_prest {get; set;}
        public int cod_lib {get; set;}
        [Required]
        public string modalidad {get; set;}
        public DateTime fecha_reserva {get; set;}
    }
}
