using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using DataService;
using LeagueOfLegendsRest.Services;



namespace LeagueOfLegendsRest
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
            string mySqlConnectionString = Configuration.GetConnectionString("developmentConnection");


            // DATAACCESS
            services.AddDbContextPool<MySqlContext>(options =>
            {
                options.UseMySql(mySqlConnectionString, ServerVersion.AutoDetect(mySqlConnectionString));
           
            });
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            // ASP SERVICES
            services.AddScoped<Services.IService.IUserService, Services.Service.UserService>();
            

            // AUTOMAPPER
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            // CONTROLLER
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
