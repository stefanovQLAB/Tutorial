using Microsoft.EntityFrameworkCore;

namespace Tutorial.Data
{
    public partial class Seed
    {
        private readonly ApplicationDbContext _context;
        private readonly IServiceProvider _serviceProvider;

        public Seed(
            ApplicationDbContext context,
            IServiceProvider serviceProvider) 
        {
            _context = context;
            _serviceProvider = serviceProvider;
        }

        public async Task InitializeAsync()
        {
            await _context.Database.MigrateAsync();
        }
    }
}