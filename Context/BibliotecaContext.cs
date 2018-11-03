using Microsoft.EntityFrameworkCore;
using Biblioteca.Models;

namespace Biblioteca.Context
 {
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base (options) 
        {

        }

       
        public DbSet<Models.bibliotecario> bibliotecario { get; set; }
        public DbSet<Models.estudiante> estudiante {get; set;}
        public DbSet<Models.libros> libros {get; set;}
        public DbSet<Models.prestamo> prestamo { get; set; }
        public DbSet<Models.reserva> reserva { get; set; }
    


    }
}