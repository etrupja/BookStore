using BookStore.Tests.Database.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Tests.Database
{
    public class MySqlToDoItemService : ITodoItemService
    {
        public List<ToDoItem> GetAllTodoItems()
        {
            ///Shkruhet logjika per komunikim me mysql
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
