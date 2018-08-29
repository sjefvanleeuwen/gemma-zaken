using App.Metrics.AspNetCore;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace drc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseMetrics()
                .UseUrls("http://*:5094")
                .UseStartup<Startup>();
    }
}
