using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ApiRestClient.Models;

namespace ApiRestClient.Services
{
    public interface ITodoService
    {
        Task<List<Todo>> GetAllAsync();
        Task<Todo> GetTodoAsync(int id);
        Task<Todo> CreateTodoAsync(Todo task);
        Task<Todo> UpdateTodoAsync(Todo task);
        Task DeleteTodoAsync(int id);
    }
}
