using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TodoCqrs.Commands.AddTodo;
using TodoCqrs.Services;

namespace TodoCqrs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        public readonly ITodoService _service;
        public readonly IMediator _mediator;

        public TodoController(ITodoService service, IMediator mediator)
        {
            this._service = service;
            this._mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetTodosAsync()
        {
            var todos = await _service.GetTodosAsync();
            return Ok(todos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTodoByIdAsync(int id)
        {
            var todo = await _service.GetTodoByIdAsync(id);
            return Ok(todo);
        }

        [HttpPost]
        public async Task<IActionResult> AddTodoAsync([FromBody] AddTodoWithResultCommand command)
        {
            var result = await _mediator.Send(command);
            
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTodoAsync([FromBody] Models.Todo todo)
        {
            var updatedTodo = await _service.UpdateTodoAsync(todo);
            return Ok(updatedTodo);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoAsync(int id)
        {
            await _service.DeleteTodoAsync(id);
            return Ok();
        }
    }
}