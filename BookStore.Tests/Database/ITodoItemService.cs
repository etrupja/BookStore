using BookStore.Tests.Database.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Tests.Database
{
    public interface ITodoItemService
    {
        List<ToDoItem> GetAllTodoItems();
        void Metoda01();
        void Metoda02();
    }
}
