using Microsoft.EntityFrameworkCore;
using Biblioteca.Models;

namespace Biblioteca.Context
 {
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base (options) 
        {

        }
        //Bibliotecario
        public DbSet<BibliotecaContext> bibliotecario { get; set; }
        //Estudiante
        public DbSet<estudiante> estudiante {get; set;}
        //Libros
        public DbSet<libros> libros {get; set;}
        //Prestamo
        public DbSet<prestamo> prestamo { get; set; }
        //Reserva
        public DbSet<reserva> reserva { get; set; }
    


    }
}
