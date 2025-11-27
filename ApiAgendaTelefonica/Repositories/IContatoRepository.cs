using ApiAgendaTelefonica.Models;
using System.Collections;
using System.Collections.Generic;

namespace ApiAgendaTelefonica.Repositories
{
    public interface IContatoRepository
    {
        IEnumerable<Contato> GetAll();
        Contato GetById(int id);
        bool Update (Contato contato);
        bool Delete (int id);
        Contato Create(Contato contato);

    }
}
