using AutoMapper;
using HighSchool.API.Config;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HighSchoolAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("default", policy =>
                {
                    policy.AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
            });

            services.AddAutoMapper();
            DatabaseHelper.SetConnection(services, Configuration);
            DependencyInjectionHelper.Register(services);
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            SwaggerHelper.SetService(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseCors("default");
            app.UseStaticFiles();
            app.UseHttpsRedirection();
            app.UseMvc();
            app.UseMvcWithDefaultRoute();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                #if DEBUG
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "High School API V1");
                #else
                c.SwaggerEndpoint("/webapi/swagger/v1/swagger.json", "High School API V1");
                #endif
            });
        }
    }
}
