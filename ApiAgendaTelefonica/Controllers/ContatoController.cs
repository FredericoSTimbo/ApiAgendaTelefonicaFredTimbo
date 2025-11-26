using ApiAgendaTelefonica.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiAgendaTelefonica.Controllers
{
    public class ContatoController : ControllerBase
    {
        private object _context;

        [Route("/api/contatos")]
        public IActionResult GetAllContatos()
        {
            return Ok(ContatoList.Tasks.Values);

        }
        [Route("/api/contatos/{id}")]
        public IActionResult GetContatosById(int id)
        {
            if (!ContatoList.Tasks.ContainsKey(id))
            {
                return NotFound();

            }
            return Ok(ContatoList.Tasks[id]);

        }
        [HttpPost]
        [Route("/api/contatos")]

        public IActionResult CreateContato([FromBody] Contato contato)
        {

            if (ContatoList.Tasks.ContainsKey(contato.Nome, contato))
            {
                ContatoList.Tasks.Add(contato.Id, contato);

                return Created();
            }

            return Conflict(contato);


        }



        [HttpPut]
        [Route("/api/contatos/{id}")]
        public IActionResult CreateContato([FromBody] Contato contato, int id)
        {
            if (id != contato.Id)
                return BadRequest();

            if (!ContatoList.Tasks.ContainsKey(id))
                return NotFound();

            var existing = ContatoList.Tasks[id];

            existing.Nome = contato.Nome;
            existing.Telefone = contato.Telefone;
            

            return Ok(existing);



        }
        [HttpDelete]
        [Route("/api/contatos/{id}")]
        public IActionResult Delete(int id)

        {
            if (!ContatoList.Tasks.ContainsKey(id))
                return NotFound();

            ContatoList.Tasks.Remove(id);
            return NoContent();

        }

    }


}




