using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NewsForum.Data;
using NewsForum.Data.Interfaces;
using NewsForum.Data.Repository;
using Microsoft.EntityFrameworkCore;
using Forum.Data.Repository;
using NewsForum.Models.AuthModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.Extensions.Logging;
using NewsForum.Services;
using Serilog;
using NewsForum.Hubs;

namespace NewsForum
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddSingleton<IEmailSender, EmailService>();
            services.AddScoped<IAllNews, NewsRepository>();
            services.AddScoped<INewsCategory, CategoryRepository>();
            services.AddTransient<IAllComments, CommentRepository>();

            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddSignalR();

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Register/Login";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                //app.UseExceptionHandler("/Home/Error");
                app.UseStatusCodePagesWithReExecute("/Error/Index", "?statusCode={0}");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseSerilogRequestLogging();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors("CorsPolicy");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "item",
                    pattern: "{controller=NewsList}/{action=GetItem}/{id?}");

                endpoints.MapControllerRoute(
                    name: "list",
                    pattern: "{controller=NewsList}/{action=GetList}/{id?}");

                endpoints.MapControllerRoute(
                    name: "addEdit",
                    pattern: "{controller=EditNews}/{action=EditForm}/{id?}");

                endpoints.MapControllerRoute(
                    name: "delete",
                    pattern: "{controller=EditNews}/{action=DeleteNews}/{id?}");

                endpoints.MapControllerRoute(
                    name: "deleteComment",
                    pattern: "{controller=Comments}/{action=DeleteComment}/{newsId}/{id}");

                endpoints.MapControllerRoute(
                    name: "editComment",
                    pattern: "{controller=Comments}/{action=EditComments}/{newsId}/{id?}");

                endpoints.MapHub<NewsHub>("/news");

                endpoints.MapRazorPages();
            });
        }
    }
}
