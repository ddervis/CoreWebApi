using FirstWebApi.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApi.Services
{
    public interface ITodoRepository
    {
        TodoItem Add(TodoItem todoitem);
        IEnumerable<TodoItem> GetALL();
        TodoItem GetById(int id);
        void Delete(TodoItem todoItem);
        void Update(TodoItem todoItem);
    }
}
