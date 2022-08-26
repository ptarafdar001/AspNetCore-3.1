using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreWebApplication
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //-->this all are Middleware's

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //--> Custom middleware's

            //app.Use(async (context, next) => 
            //{
            //    await context.Response.WriteAsync("Hello from my First middleware\n");
            //    await next();
            //    await context.Response.WriteAsync("Hello from my First middleware Response\n");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from my Second middleware\n");
            //    await next();
            //    await context.Response.WriteAsync("Hello from my Second middleware Response\n");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from my Third middleware\n");
            //    await next();
            //    await context.Response.WriteAsync("Hello from my Third middleware Response\n");
            //});

            app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!\n");
            //    });
            //});

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/prabir", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello Prabir!\n");
            //    });
            //});

            // --> How to Know all the Inbuild Environment's
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        if (env.IsDevelopment())
            //        {
            //            await context.Response.WriteAsync("Hello from dev\n");
            //        }
            //        else if (env.IsProduction())
            //        {
            //            await context.Response.WriteAsync("Hello from prod\n");
            //        }
            //        else if (env.IsStaging())
            //        {
            //            await context.Response.WriteAsync("Hello from steg\n");
            //        }
            //        else
            //            await context.Response.WriteAsync(env.EnvironmentName);
            //    });
            //});

            //--> Custom Environment
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        if (env.IsEnvironment("DevPrabir"))
            //        {
            //            await context.Response.WriteAsync("Hello from Prabir's dev Envirenment\n");
            //        }
            //        else
            //            await context.Response.WriteAsync(env.EnvironmentName);
            //    });
            //});

            // --> this endpoints is for controller 
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
