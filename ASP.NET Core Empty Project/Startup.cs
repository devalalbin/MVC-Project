using ASP.NET_Core_Empty_Project.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using ASP.NET_Core_Empty_Project.Models;
using Microsoft.AspNetCore.Identity;

namespace ASP.NET_Core_Empty_Project
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(10); //how long a session should last if not used
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });


            services.AddDbContext<ApplicationDbContext>(
                options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = false).AddDefaultUI().AddDefaultUI().AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();
         

            services.AddControllersWithViews();

            services.AddRazorPages();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseHttpsRedirection();

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "Default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                    );
                endpoints.MapControllerRoute(name: "info",
                    pattern: "About",
                    defaults: new { controller = "Info", action = "About" }); //Custom route
                endpoints.MapControllerRoute(name: "doctor", //When enterying /FeverCheck directs to the doctor
                    pattern: "FeverCheck",
                    defaults: new { controller = "Doctor", action = "FeverCheck" }); //Custom route
                endpoints.MapControllerRoute(name: "guessing game", //When enterying /FeverCheck directs to the doctor
                    pattern: "GuessingGame",
                    defaults: new { controller = "GuessingGame", action = "Game" }); //Custom route
                endpoints.MapRazorPages();

            });
        }
    }
}
