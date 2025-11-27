using ApiAgendaTelefonica.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiAgendaTelefonica
{
    public class ContatoDbContext : DbContext
    {
        public DbSet<Contato> Contatos => Set<Contato>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=c:\\ApiSqlite\\ApiSqlite.db");

            base.OnConfiguring(optionsBuilder);
        }
    }
}