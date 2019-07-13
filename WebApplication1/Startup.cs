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
using WebApplication1.Models;

namespace WebApplication1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<IEmployeeRepository, EmployeeRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env ,
                              ILogger<Startup> logger )
        {
            if (env.IsDevelopment())
            {
                DeveloperExceptionPageOptions developerExceptionPage = new DeveloperExceptionPageOptions()
                {
                    SourceCodeLineCount = 15
                };
                app.UseDeveloperExceptionPage(developerExceptionPage);
            }

            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
          

            app.Run(async (context) =>
            {
              
                Process process = Process.GetCurrentProcess();
                var str = " this is inside run method which is a terminal middleware and the process name is :";
                var str2 = " the name of the environment is :" + env.EnvironmentName;
                await context.Response.WriteAsync(str2+str+process.ProcessName);
            });
        }
    }
}
