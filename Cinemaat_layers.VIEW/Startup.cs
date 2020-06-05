using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinemaat_layers.DAL;
using Cinemaat_layers.DAL.Context_Classes;
using Cinemaat_layers.INTERFACES.Context;
using Cinemaat_layers.INTERFACES.Logic;
using Cinemaat_layers.LOGIC;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Cinemaat_layers.VIEW
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            services.AddSingleton<IConfiguration>(Configuration);

            services.AddScoped<IMovieContext, MovieContext>();
            services.AddScoped<IShoppingCartContext, ShoppingCartContext>();
            services.AddScoped<IOrderContext, OrderContext>();
            services.AddScoped<IOrderLogic, OrderLogic>();
            services.AddScoped<IMovieHallContext, MovieHallContext>();
            services.AddScoped<ISeatContext, SeatContext>();
            services.AddScoped<IAgendaContext, AgendaContext>();
            services.AddScoped<IAgendaLogic, AgendaLogic>();
            services.AddScoped<IUserRegistrationContext, UserRegistrationContext>();
            services.AddScoped<ILoginLogic, LoginLogic>();
            services.AddScoped<ILoginContext, LoginContext>();
            services.AddScoped<IMovieLogic, MovieLogic>();
            services.AddScoped<IUserRegistrationLogic, UserRegistrationLogic>();
            services.AddScoped<IReviewContext, ReviewContext>();
            services.AddScoped<IReviewLogic, ReviewLogic>();
            

            services.AddTransient(_ => new DatabaseConnection(Configuration.GetConnectionString("DefaultConnection")));

            services.AddControllersWithViews();
            
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
            app.UseSession();

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
