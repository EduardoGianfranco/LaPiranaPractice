using Microsoft.EntityFrameworkCore;

namespace LaPiranaPractice.Models
{
    public class PiranaContext : DbContext
    {
        public DbSet<Contacto> Contactos { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public PiranaContext(DbContextOptions dco) : base(dco){
            
        }
    }
}