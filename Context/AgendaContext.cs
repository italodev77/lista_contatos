using api_study.Entities;
using Microsoft.EntityFrameworkCore;

namespace api_study.Context
{
    public class AgendaContext: DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options): base(options)
        {

        }

        public DbSet<Contato> Contatos { get; set; }
    }
}
