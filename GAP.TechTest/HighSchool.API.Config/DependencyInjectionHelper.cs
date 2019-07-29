using HighSchool.Domain.Services;
using HighSchool.Infrastructure.Context;
using HighSchool.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HighSchool.API.Config
{
    public static class DependencyInjectionHelper
    {
        public static void Register(IServiceCollection services, IConfiguration Configuration)
        {
            services.AddScoped<DatabaseContext, DatabaseContext>();
            

            #region Infrastructure
            services.AddScoped<IMarkRepository, MarkRepository>();
            #endregion

            #region Domain
            services.AddScoped<IMarkService, MarkService>();
            #endregion

            
        }
    }
}
