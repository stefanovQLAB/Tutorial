using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tutorial.Data;
using Tutorial.Models;

namespace Tutorial.Controllers
{
    public class TestController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TestController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> IndexAsync()
        {
            var developers = await _context.Developers.ToListAsync();
            var developer = await _context.Developers.FirstOrDefaultAsync();

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
