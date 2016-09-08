using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace HWApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var host = new WebHostBuilder()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseKestrel()
                .UseStartup<HWStartup>()
                .Build();

            host.Run();
        }
    }
}
