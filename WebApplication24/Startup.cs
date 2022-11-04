using FluentAssertions.Common;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication24.Model;
using WebApplication24.Models;
using WebApplication24.Service;
using WebApplication24.Service.ClinetService;
using WebApplication24.Service.clMenuServices;
using WebApplication24.Service.Edu_skillitemService;
using WebApplication24.Service.EduFieldService;
using WebApplication24.Service.ProductsService;
using WebApplication24.Service.SemesterService;
using WebApplication24.Service.SupportService;
using WebApplication24.Service.YearStudyService;

namespace WebApplication24
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebApplication24", Version = "v1" });
            });
            services.AddDbContext<erpContext>(x => x.UseSqlServer(Configuration.GetConnectionString("mostafa2050")));
             services.AddDbContext< masterContext>(x => x.UseSqlServer(Configuration.GetConnectionString("mostafa20")));
            services.AddDbContext<ServiceContext>(x => x.UseSqlServer(Configuration.GetConnectionString("mostafa9090")));


                           services.AddScoped<IEduFieldService, EduFieldService>();
                  services.AddScoped<IEduSkillitemService, EduSkillitemService>();
                       services.AddScoped<IYearStudyService, YearStudyService>();
                        services.AddScoped<ISemesterService, SemesterService>();
                         services.AddScoped<ISupportService, SupportService>();
                        services.AddScoped<IProductservice, ProductService>();
                         services.AddScoped<IClinetService, ClinetService>();
                      services.AddScoped<IclMenuServices, clMenuServices>();



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebApplication24 v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
