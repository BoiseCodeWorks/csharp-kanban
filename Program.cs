using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using csharp_kanban.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace csharp_kanban
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
