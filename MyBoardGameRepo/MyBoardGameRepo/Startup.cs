using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using MyBoardGameRepo.Models;
using System;

namespace MyBoardGameRepo
{
    public class Startup
    {
        // F i e l d s  &  P r o p e r t i e s

        public IConfiguration _configuration { get; }


        // C o n s t r u c t o r s
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        // M e t h o d s

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddDbContext<AppDbContext>(options => options.UseSqlServer
            //    (_configuration.GetConnectionString("DefaultConnection")));
            //services.AddDbContext<AppDbContext>(options => options.UseSqlServer
            //    (_configuration.GetConnectionString("AzureConnection")));
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer
                (System.Environment.GetEnvironmentVariable("EzekielsBoardGameRepoAzureConnection")));

            services.AddScoped<IBoardGameRepository, EfBoardGameRepository>();
            services.AddScoped<IPlayerRepository,    EfPlayerRepository>();
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddControllersWithViews();

            // services.AddMemoryCache();
            services.AddDistributedMemoryCache();
            services.AddSession(
               options =>
               {
                   options.IdleTimeout = TimeSpan.FromMinutes(10);
               }
            );

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseSession();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
