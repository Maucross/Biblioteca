using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Models
{
    public class MvcBibliotecaContext : DbContext
    {
        public MvcBibliotecaContext (DbContextOptions<MvcBibliotecaContext> options)
        : base(options)
        {}
        public DbSet<MvcBibliotecaContext.Models.bibliotecario> bibliotecario {get; set;}
    }
}