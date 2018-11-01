namespace Biblioteca.Models
{
    public class reserva
    {
        [Key]
        public int cod_res {get; set;}
        public int cod_prest {get; set;}
        [Required]
        public Datetime fecha_realizacion {get; set;}
        public string estado_reserva {get; set;}
    }
}
