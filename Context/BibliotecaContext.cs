using Microsoft.EntityFrameworkCore;
using Biblioteca.Models;

namespace Biblioteca.Context
 {
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base (options) 
        {

        }

        public DbSet<BibliotecaContext> bibliotecario { get; set; }
        public DbSet<estudiante> estudiante {get; set;}
        public DbSet<libros> libros {get; set;}
        public DbSet<prestamo> prestamo { get; set; }
        public DbSet<reserva> reserva { get; set; }
    


    }
}