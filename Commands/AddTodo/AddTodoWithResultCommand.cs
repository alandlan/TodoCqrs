using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using TodoCqrs.Models;

namespace TodoCqrs.Commands.AddTodo
{
    public class AddTodoWithResultCommand : IRequest<CustomResult<Todo>>
    {
        public string? Name { get; set; }
        public bool Done { get; set; }

        //convert to Todo
        public Todo ToEntity() => new (Name, Done);
    }
}