using Microsoft.EntityFrameworkCore;
using ProjetoMvcDio.Models;

namespace ProjetoMvcDio.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }

        public DbSet<Contato> Contatos { get; set; }
    }
}
