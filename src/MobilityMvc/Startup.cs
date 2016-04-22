﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Data.Entity;
using MobilityMvc.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MobilityMvc
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services/*, IHostingEnvironment env*/)
        {
            services.AddMvc();


            //string connString = null;

            //if (env.IsDevelopment())
            //{
             var connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MobilityMvcDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //}
            //else
            //{
            //var connString = @"Server=tcp:mobilitymvcsr.database.windows.net,1433;Database=MoblilityMvcDB;User ID=NinibMobility;Password=Assyriska01;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            //}

            services.AddEntityFramework()
                .AddSqlServer()
                .AddDbContext<IdentityDbContext>(options =>
                options.UseSqlServer(connString));

            services.AddEntityFramework()
                .AddSqlServer()
                .AddDbContext<ProductContext>(options =>
                options.UseSqlServer(connString));

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<IdentityDbContext>()
                .AddDefaultTokenProviders();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseIdentity();
            //app.UseSession();
            app.UseMvcWithDefaultRoute();
        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
