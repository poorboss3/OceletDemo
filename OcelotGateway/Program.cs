using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

namespace OcelotGateway
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new WebHostBuilder()
               .UseKestrel()
               .UseContentRoot(Directory.GetCurrentDirectory())
               .ConfigureAppConfiguration((hostingContext, config) =>
               {
                   config
                       .SetBasePath(hostingContext.HostingEnvironment.ContentRootPath)
                       .AddJsonFile("ocelot.json");
               })
               .ConfigureServices(s =>
               {
                   s.AddOcelot();
               })
               .ConfigureLogging((hostingContext, logging) =>
               {
                   //add your logging
               })
               .UseIIS()
               .Configure(app =>
               {
                   app.UseOcelot().Wait();
               })
               .Build()
               .Run();
        }
    }
}
