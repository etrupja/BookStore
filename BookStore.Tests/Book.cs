using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Tests
{
    public class Book
    {
        public Book() { }
        public Book(int id, string title, int numberOfPages)
        {
            Id = id;
            Title = title;
            NrOfPages = numberOfPages;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int NrOfPages { get; set; }
    }
}
