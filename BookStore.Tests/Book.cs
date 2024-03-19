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
        public Book(int id, string title)
        {
            Id = id;
            Title = title;

            Console.WriteLine($"(Constructor) Book Id: {Id} Title: {Title}");
        }

        public int Id { get; set; }
        public string Title { get; set; }
    }
}
