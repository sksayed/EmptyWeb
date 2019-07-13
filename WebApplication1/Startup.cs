using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;
using Microsoft.Extensions.Logging;

namespace WebApplication1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvcCore();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env ,
                              ILogger<Startup> logger )
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Use(async (context, next) =>
            {
                logger.LogInformation("Middleware 1 : an incoming request is recieved ");
                await next();
                logger.LogInformation("Middleware 1: middleware 1 is ending here ");
            }
            );

            app.Use(async (context, next) =>
            {
                logger.LogInformation("Middleware 2 : an incoming request is recieved ");
                await next();
                logger.LogInformation("Middleware 2: middleware 2 is ending here ");
            }
          );


            app.Run(async (context) =>
            {
                Process process = Process.GetCurrentProcess();
                var str = " this is inside run method which is a terminal middleware and the process name is :";
                await context.Response.WriteAsync(str+process.ProcessName);
            });
        }
    }
}
