using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace HWApp
{
    public class HWStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("<p>Pre Processing</p>");

                await next();

                await context.Response.WriteAsync("<p>Post Processing</p>");
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World. The Time is: " + DateTime.Now.ToString("hh:mm:ss tt"));
            });

        }
    }
}