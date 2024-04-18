using Microsoft.AspNetCore.Mvc;

namespace BookStore.App.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
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
