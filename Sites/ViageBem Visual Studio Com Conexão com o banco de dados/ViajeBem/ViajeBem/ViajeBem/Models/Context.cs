using Microsoft.EntityFrameworkCore;

namespace ViajeBem.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
                
        } 

        public DbSet<Cliente> clientes { get; set; }

        public DbSet<Contato> contatos { get; set; }

        public DbSet<Destino> destino { get; set; }

    }
}
