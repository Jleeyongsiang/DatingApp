using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DatingApp.API
{
    public class Program
    {
        //Starting point of an application
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        //Create defaults, use Kestrel webserver to host API, configure logging, read from configuration file which contains our app settings 
        //Logging in production mode and development mode
        //Additional configuration can be added in the start up class
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
