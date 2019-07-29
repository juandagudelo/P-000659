using HighSchool.Domain.Services;
using HighSchool.Infrastructure.Context;
using HighSchool.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HighSchool.API.Config
{
    public static class DependencyInjectionHelper
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<DbContext, DatabaseContext>();

            #region Infrastructure
            services.AddScoped<IMarkRepository, MarkRepository>();
            #endregion

            #region Domain
            services.AddScoped<IMarkService, MarkService>();
            #endregion

            
        }
    }
}
