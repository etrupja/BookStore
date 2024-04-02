using BookStore.Tests.Database.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Tests.Database
{
    public class SqlToDoItemService : ITodoItemService
    {
        public List<ToDoItem> GetAllTodoItems()
        {
            return new List<ToDoItem>();
        }

        public void Metoda01()
        {
            throw new NotImplementedException();
        }

        public void Metoda02()
        {
            throw new NotImplementedException();
        }
    }
}
