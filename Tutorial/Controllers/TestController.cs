using Domain;
using Microsoft.AspNetCore.Mvc;
using Tutorial.Models;

namespace Tutorial.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var error = new Error
            {
                Id = 5,
                Message = "qwerty"
            };
            var viewModel = new ErrorViewModel
            {
                Id = error.Id,
                Message = error.Message,
                Count = 10
            };
            return View(viewModel);
        }
    }
}
