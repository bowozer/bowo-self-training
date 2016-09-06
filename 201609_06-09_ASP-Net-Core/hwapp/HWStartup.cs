using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace HWApp
{
    public class HWStartup
    {
        public void Configure(IApplicationBuilder app)
        {
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