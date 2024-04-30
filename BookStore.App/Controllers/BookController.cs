using BookStore.App.Data;
using BookStore.App.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.App.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            var allBooks = FakeData.GetAllBooks();

            var allBooksData = allBooks.Select(n => new GetBookVM()
            {
                Id = n.Id,
                Title = n.Title,
                Author = n.Author
            }).ToList();

            return View(allBooksData);
        }

        public IActionResult Details(int id)
        {
            var allBooks = FakeData.GetAllBooks();
            var book = allBooks.FirstOrDefault(n => n.Id == id);

            return View(book);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Modify()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}
