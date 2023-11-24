using Microsoft.EntityFrameworkCore;

namespace Petshop1.Models
{
    public class Contexto :DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Animal> Animais { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Servico> Servicos { get; set; }

        public DbSet<TipoServico> TipoServicos { get; set; }
    }
}
