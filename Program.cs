using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace TestPipeline
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder().Build().Run();
        }

        public static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
