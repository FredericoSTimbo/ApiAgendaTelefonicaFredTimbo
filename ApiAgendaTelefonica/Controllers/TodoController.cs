using ApiAgendaTelefonica.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ApiAgendaTelefonica.Controllers
{
    public class TodoController : ControllerBase
    {
        List<Todo> todos = new List<Todo>

        {
            new Todo {Id = 1, Title = "Comprar leite", IsCompleted = true},
            new Todo {Id = 2, Title = "Estudar AspNet", IsCompleted = true},
            new Todo {Id = 3, Title = "Fazer exercícios", IsCompleted = false},
        };

        [Route("/api/todo")]
        public IActionResult GetAllTodos()  
        {
            return Ok();

        }
    }
}
