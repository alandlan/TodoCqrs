using TodoCqrs.Models;

namespace TodoCqrs.Services
{
    public class TodoService : ITodoService
    {
        public Task<Todo> AddTodoAsync(Todo todo)
        {
            //fake implementation
            Thread.Sleep(1000);
            return Task.FromResult(todo);
        }

        public Task DeleteTodoAsync(int id)
        {
            //fake implementation
            Thread.Sleep(1000);
            return Task.CompletedTask;
        }

        public Task<Todo> GetTodoByIdAsync(int id)
        {
            //fake implementation
            Thread.Sleep(1000);
            return Task.FromResult(new Todo { Id = id, Name = "Todo " + id, Done = false });
        }

        public Task<List<Todo>> GetTodosAsync()
        {
            //fake implementation
            Thread.Sleep(1000);
            return Task.FromResult(new List<Todo>
            {
                new Todo { Id = 1, Name = "Todo 1", Done = false },
                new Todo { Id = 2, Name = "Todo 2", Done = false },
                new Todo { Id = 3, Name = "Todo 3", Done = false },
                new Todo { Id = 4, Name = "Todo 4", Done = false },
                new Todo { Id = 5, Name = "Todo 5", Done = false },
            });
        }

        public Task<Todo> UpdateTodoAsync(Todo todo)
        {
            //fake implementation
            Thread.Sleep(1000);
            return Task.FromResult(todo);
        }
    }
}