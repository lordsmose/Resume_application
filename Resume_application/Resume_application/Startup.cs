using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Resume_application.DndAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Resume_application.Infrastructure.Constants;

namespace Resume_application
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
            services.AddControllersWithViews();
            services.AddHttpClient();
            services.AddScoped<IDndAPISpellService, DndAPISpellService>();

            services.AddHttpClient(DND_API, c =>
            {
                c.BaseAddress = new Uri("https://www.dnd5eapi.co/");
                c.DefaultRequestHeaders.Add("Accept", "application/json");
                c.DefaultRequestHeaders.Add("Accept", "text/html");
                c.DefaultRequestHeaders.Add("Connection", "keep-alive");
                //c.DefaultRequestHeaders.Add("Content-Type", "application/json");
                c.DefaultRequestHeaders.Add("DNT", "1");
                c.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate, br");
            });
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
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
