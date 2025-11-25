using ApiAgendaTelefonica.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ApiAgendaTelefonica.Controllers
{
    public class TodoController : ControllerBase
    {


        [Route("/api/todo")]
        public IActionResult GetAllTodos()
        {
            return Ok(TodoList.Tasks.Values);

        }
        [Route("/api/todo/{id}")]
        public IActionResult GetTodoById(int id)
        {
            if (!TodoList.Tasks.ContainsKey(id))
            {
                return NotFound();

            }
            return Ok(TodoList.Tasks[id]);

        }
        [HttpPost]
        [Route("/api/todo")]
        public IActionResult CreateTodo([FromBody] Todo todo)
        {
            if (TodoList.Tasks.ContainsKey(todo.Id))
                return Conflict(todo);


            TodoList.Tasks.Add(todo.Id, todo);

            return Created();


        }
        [HttpPut]
        [Route("/api/todo/{id}")]
        public IActionResult CreateTodo([FromBody] Todo todo, int id)
        {
            if (id != todo.Id)
                return BadRequest();

            if (!TodoList.Tasks.ContainsKey(id))
                return NotFound();

            var existing = TodoList.Tasks[id];

            existing.Title = todo.Title;
            existing.Description = todo.Description;
            existing.IsCompleted = todo.IsCompleted;

            return Ok(existing);



        }
        [HttpDelete]
        [Route("/api/todo/{id}")]
        public IActionResult Delete(int id)

        {
            if (!TodoList.Tasks.ContainsKey(id))
                return NotFound();

            TodoList.Tasks.Remove(id);
            return NoContent();

        }

    }


}




