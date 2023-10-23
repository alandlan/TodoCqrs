using MediatR;
using TodoCqrs.Services;

namespace TodoCqrs.Commands.AddTodo
{
    public class AddTodoCommandHandler  : IRequestHandler<AddTodoCommand>
    {
        private readonly ITodoService _todoService;

        public AddTodoCommandHandler(ITodoService todoService)
        {
            _todoService = todoService;
        }

        public async Task Handle(AddTodoCommand request, CancellationToken cancellationToken)
        {
            var todo = request.ToEntity();
            await _todoService.AddTodoAsync(todo);
        }
    }
}