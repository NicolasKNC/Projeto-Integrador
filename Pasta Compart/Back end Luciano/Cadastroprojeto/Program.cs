namespace IndianoChato
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.Configure(app =>
                    {
                        app.UseStaticFiles();
                        app.UseRouting();
                        app.UseEndpoints(endpoints =>
                        {
                            
                            endpoints.MapFallbackToFile("index.html"); // Redireciona todas as outras solicitações para index.html
                        });
                    });
                });
    }
}