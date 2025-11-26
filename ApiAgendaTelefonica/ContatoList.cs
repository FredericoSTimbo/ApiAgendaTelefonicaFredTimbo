using ApiAgendaTelefonica.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiAgendaTelefonica
{
    public class ContatoList
    {
        public static Dictionary<int, string Contato> Tasks { get; set; }

        static ContatoList()
        {
            Tasks = new()
            {
                {1, new() {Id = 1, Nome = "João", Telefone = "999999999", } },
                {2, new() {Id = 2, Nome = "Maria", Telefone = "888888888", } },
                {3, new() {Id = 3, Nome = "Paulo", Telefone = "777777777", } },
            };

        }



        
            
        


    }
}
