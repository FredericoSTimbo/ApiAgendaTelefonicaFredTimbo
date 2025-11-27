using ApiAgendaTelefonica.Models;
using ApiAgendaTelefonica.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAgendaTelefonica.Controllers
{
    public class ContatoController : ControllerBase
    {
        private readonly IContatoRepository contatoRepository;
        public ContatoController(IContatoRepository contatoRepository)
        {
            this.contatoRepository = contatoRepository;
        }
        [Route("/api/contatos")]
        public IActionResult GetAllContatos()
        {
            return Ok(contatoRepository.GetAll());


        }
        [Route("/api/contatos/{id}")]
        public IActionResult GetContatosById(int id)
        {
            var contato = contatoRepository.GetById(id);

            if (contato == null)
            {
                return NotFound();

            }
            return Ok(contato);

        }
        [HttpPost]
        [Route("/api/contatos")]

        public IActionResult CreateContato([FromBody] Contato contato)
        {
            var existingContato = contatoRepository.GetById(contato.Id);
            if (existingContato != null)
                return Conflict(existingContato);

            contato = contatoRepository.Create(contato);
            return Created();


        }



        [HttpPut]
        [Route("/api/contatos/{id}")]
        public IActionResult CreateContato([FromBody] Contato contato, int id)
        {
            if (id != contato.Id)
                return BadRequest();

            var existingContato = contatoRepository.GetById(contato.Id);
            if (existingContato == null)
                return NotFound();

            existingContato.Nome = contato.Nome;
            existingContato.Telefone = contato.Telefone;
            
            var retorno = contatoRepository.Update(existingContato);


            return Ok(retorno);




        }
        [HttpDelete]
        [Route("/api/contatos/{id}")]
        public IActionResult Delete(int id)

        {
            var existingContato = contatoRepository.GetById(id);
            if (existingContato == null)
                return NotFound();

            contatoRepository.Delete(id);
            return NoContent();

        }

    }


}




