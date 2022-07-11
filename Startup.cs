using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShopVVK.Data;
using ShopVVK.Data.Interfaces;
using ShopVVK.Data.Mocks;
using ShopVVK.Data.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopVVK.Data.Models;

namespace WebApplication1
{
    public class Startup
    {

        //private iconfigurationroot _confstring;

        //public startup(ihostingenvironment hostenv)
        //{
        //    _confstring = new configurationbuilder().setbasepath(hostenv.contentrootpath).addjsonfile("dbsettings.json").build();
        //}

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddDbContext<AppDBContent>(options => options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ShopVVK;Trusted_Connection=True;MultipleActiveResultSets=true"));
            services.AddTransient<IAllCars, MockCars>();
            services.AddTransient<ICarsCategory, MockCategory>();
            //services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => ShopCart.GetCart(sp));
            //services.AddMvc();
            //services.AddMemoryCache();
            //services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            //app.UseSession();
            //app.UseMvcWithDefaultRoute();
            
        }
    }
}
