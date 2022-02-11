namespace Tutorial.Data
{
    public static class WebApplicationExtension
    {
        public static void Seed(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var serviceProvider = scope.ServiceProvider;

            try
            {
                var seed = serviceProvider.GetRequiredService<Seed>();
                seed.InitializeAsync().Wait();
            }
            catch (Exception ex)
            {
            }
        }
    }


}
