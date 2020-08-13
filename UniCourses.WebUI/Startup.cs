using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Stripe;
using UniCourses.Bl.Repositories;
using UniCourses.Dal.Contexts;
using UniCourses.Dal.Entities;
using UniCourses.WebUI.Utility;

namespace UniCourses.WebUI
{
    public class Startup
    {
        private readonly IConfiguration configuration;

        public Startup(IConfiguration _configuration)
        {
            configuration = _configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MyContext>();
            services.AddScoped(typeof(Repository<>));
            services.AddControllersWithViews();
          //  services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<MyContext>();
            services.AddDbContext<MyContext>(options => options.UseSqlServer(configuration.GetConnectionString("MyCon1")));
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
            {
                options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
                options.AccessDeniedPath = "/yetkilendirme";
                options.LoginPath = "/giris";
                options.LogoutPath = "/cikis";
            });
            services.Configure<StripeSettings>(configuration.GetSection("Stripe"));
            /* services.AddAuthentication().AddGoogle(options =>
             {
                 options.ClientId = "253390453584-cplglhlk3dj8qtgpj7nqfkc2221l79o9.apps.googleusercontent.com";
                 options.ClientSecret = "wki8VHwwR5ttIEM01N17yt-1";
             });
             services.AddIdentity<IdentityUser, IdentityRole>()
         .AddEntityFrameworkStores<MyContext>();*/
        } 

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else app.UseStatusCodePagesWithReExecute("/Hata/{0}");
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            StripeConfiguration.ApiKey = configuration.GetSection("Stripe")["SecretKey"];
            app.UseEndpoints(ep => {
                                ep.MapControllerRoute(name: "areas", pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                ep.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
