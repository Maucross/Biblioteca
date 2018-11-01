using Microsoft.EntityFrameworkCore;
using Biblioteca.Models;
using jojo.Models;
namespace Biblioteca.Context
 {
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base (options) 
        {

        }

        /*public DbSet<BuscarCatalogo> BuscarCatalogo { get; set; }
        public DbSet<DetalleLib> DetalleLib {get; set;}
        public DbSet<GenerarPrestamoB> GenerarPrestamoB {get; set;}
        public DbSet<GenerarPrestamoE> GenerarPrestamoE { get; set; }
        public DbSet<InfoLibro> InfoLibro { get; set; }
        public DbSet<login> login {get; set;}
        public DbSet<ManternerReserva> ManternerReserva {get; set;}
        public DbSet<Prestamo> Prestamo {get; set;}
        public DbSet<Registrar> Registrar {get; set;} */


    }
}