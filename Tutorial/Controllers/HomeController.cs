using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Tutorial.Data;
using Tutorial.Models;

namespace Tutorial.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(
            ILogger<HomeController> logger, 
            ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var developers = await _context.Developers
                .Take(10)
                .Include(x=>x.Errors)
                .ToListAsync();
            
            return View();
        }

        public async Task<IActionResult> PrivacyAsync()
        {
            var developer = new Developer();

            _context.Developers.Add(developer);

            _context.Developers.Add(new Developer { 
            Name = "Vasya",
            Errors = new List<Error>
            {
                new Error { Message="ошибка", DateOfError=DateTime.Now}
            }
            });

          var developers = new List<Developer>();

            _context.Developers.AddRange(developers);


            await _context.SaveChangesAsync();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}