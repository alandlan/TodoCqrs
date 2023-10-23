using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoCqrs.Models;

namespace TodoCqrs.Services
{
    public interface ITodoService
    {
        //add todo
        Task<Todo> AddTodoAsync(Todo todo);

        //get all todos
        Task<List<Todo>> GetTodosAsync();

        //get todo by id
        Task<Todo> GetTodoByIdAsync(int id);

        //update todo
        Task<Todo> UpdateTodoAsync(Todo todo);

        //delete todo
        Task DeleteTodoAsync(int id);

        
    }
}