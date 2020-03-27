using FirstWebApi.Models;
using FirstWebApi.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApi.Services
{
    public class InMemoryTodoItemRepository : ITodoRepository
    {
        private readonly WebApiContext _context;

        public InMemoryTodoItemRepository(WebApiContext context)
        {
            _context = context;
        }

        public TodoItem Add(TodoItem todoitem)
        {
            var addedTodoItem = _context.Add(todoitem);
            _context.SaveChanges();
            todoitem.Id = addedTodoItem.Entity.Id;

            return todoitem;
        }

        public void Delete(TodoItem todoItem)
        {
            _context.Remove(todoItem);
            _context.SaveChanges();
        }

        public IEnumerable<TodoItem> GetALL()
        {
            return _context.TodoItems.ToList();
        }

        public TodoItem GetById(int id)
        {
            return _context.TodoItems.FirstOrDefault(x => x.Id == id);
        }

        public void Update(TodoItem todoItem)
        {
            var todoItemUpdate = GetById(todoItem.Id);
            todoItemUpdate.Name = todoItem.Name;
            todoItemUpdate.IsComplete = todoItem.IsComplete;
            _context.Update(todoItemUpdate);
            _context.SaveChanges();

        }
    }
}
