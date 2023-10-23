using MediatR;
using TodoCqrs.Models;

namespace TodoCqrs.Commands.AddTodo
{
    public class AddTodoCommand : IRequest
    {
        public string? Name { get; set; }
        public bool Done { get; set; }   

        //convert to Todo
        public Todo ToEntity() => new (Name, Done);
    }
}