using HighSchool.API.Config;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace HighSchoolAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();
            DatabaseHelper.CreateDatabase(host);

            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
