using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace HWApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseUrls()
                .UseIISIntegration()
                .UseStartup<HWStartup>()
                .Build();

            host.Run();
        }
    }
}
