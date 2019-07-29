using HighSchool.Infrastructure.Context;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace HighSchool.API.Config
{
    public class DatabaseHelper
    {
        public static void SetConnection(IServiceCollection services, IConfiguration configuration)
        {
            //configure database
            services.AddDbContext<DatabaseContext>(options =>
            {
                options.UseSqlite(configuration.GetConnectionString("AppDatabaseConnection"));
                
            });
        }

        public static void CreateDatabase(IWebHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<DatabaseContext>();
                    DbInitializer.Initialize(context);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
