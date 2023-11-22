using Microsoft.EntityFrameworkCore;

namespace Petshop1.Models
{
    public class Contexto :DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Animal> Animais { get; set; }
    }
}
