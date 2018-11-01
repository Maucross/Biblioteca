namespace Biblioteca.Views.Context
 {
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base (options) 
        {

        }

        public DbSet<BuscarCatalogo> BuscarCatalogo { get; set; }
        public Dbset<DetalleLib> DetalleLib {get; set;}
        public DbSet<GenerarPrestamoB> GenerarPrestamoB {get; set;}
        public DbSet<GenerarPrestamoE> GenerarPrestamoE { get; set; }
        public DbSet<InfoLibro> InfoLibro { get; set; }
        public Dbset<login> login {get; set;}
        public Dbset<ManternerReserva> ManternerReserva {get; set;}
        public Dbset<Prestamo> Prestamo {get; set;}
        public Dbset<Registrar> Registrar {get; set;}


    }
}