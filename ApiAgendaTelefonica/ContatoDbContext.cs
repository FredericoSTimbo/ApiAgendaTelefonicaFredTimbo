using ApiAgendaTelefonica.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiAgendaTelefonica
{
    public class ContatoDbContext : DbContext
    {
        public DbSet<Contato> Contatos => Set<Contato>();
    }
}
