using MediatR;
using TodoCqrs.Models;
using TodoCqrs.Services;

namespace TodoCqrs.Commands.AddTodo
{
    public class AddTodoWithResultCommandHandler : IRequestHandler<AddTodoWithResultCommand, CustomResult<Todo>>
    {
        private readonly ITodoService _todoService;

        public AddTodoWithResultCommandHandler(ITodoService todoService)
        {
            _todoService = todoService;
        }

        public async Task<CustomResult<Todo>> Handle(AddTodoWithResultCommand request, CancellationToken cancellationToken)
        {
            var todo = request.ToEntity();
            var result = await _todoService.AddTodoAsync(todo);

            return new CustomResult<Todo>(data: result, message: "Todo added successfully"); 
        }
    }
}