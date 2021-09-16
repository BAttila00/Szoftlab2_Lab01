using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Otthonbazar.Data;

namespace Otthonbazar {
    public class Program {
        public static void Main(string[] args) {
            var webHost = CreateWebHostBuilder(args).Build();
            using (var scope = webHost.Services.CreateScope()) {
                scope.ServiceProvider.GetRequiredService<ApplicationDbContext>().Database.Migrate();
            }
            webHost.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
