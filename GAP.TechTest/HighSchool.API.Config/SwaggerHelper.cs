using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace HighSchool.API.Config
{
    public static class SwaggerHelper
    {
        public static void SetService(IServiceCollection services, IConfiguration configuration)
        {
            services.AddSwaggerGen(options =>
            {
               options.SwaggerDoc("v1", new Info { Title = "High School API", Version = "v1" });
            });
        }
    }
}
