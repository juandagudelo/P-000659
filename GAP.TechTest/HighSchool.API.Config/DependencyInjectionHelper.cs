using HighSchool.Domain.Services;
using HighSchool.Domain.Services.Interfaces;
using HighSchool.Infrastructure.Context;
using HighSchool.Infrastructure.Repositories;
using HighSchool.Infrastructure.Repositories.Interfaces;
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
            services.AddScoped<ISubjectRepository, SubjectRepository>();
            #endregion

            #region Domain
            services.AddScoped<IMarkService, MarkService>();
            services.AddScoped<ISubjectService, SubjectService>();
            #endregion


        }
    }
}
