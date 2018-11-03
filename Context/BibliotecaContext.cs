using Microsoft.EntityFrameworkCore;
using System;
using Biblioteca.Models;

namespace Biblioteca.Context
 {
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base (options) 
        {

        }
<<<<<<< HEAD

       
        public DbSet<Models.bibliotecario> bibliotecario { get; set; }
        public DbSet<Models.estudiante> estudiante {get; set;}
        public DbSet<Models.libros> libros {get; set;}
        public DbSet<Models.prestamo> prestamo { get; set; }
        public DbSet<Models.reserva> reserva { get; set; }
=======
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
>>>>>>> c3c4d61ada93c267f974b9b66efbf455d519842d
    


    }
}
