using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Bucket.EFCoreContext
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IConfiguration configuration = GetConfig();
            var conStr = configuration.GetValue<string>("Constr");
        }
        public static IConfiguration GetConfig()
        {
            var services = new ServiceCollection();

            var conBuilder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
               .AddJsonFile("appsettings.json", true, true);
            var con = conBuilder.Build();
            services.AddSingleton<IConfiguration>(con);
            var ser = services.BuildServiceProvider().GetService<IConfiguration>();
            return ser;

        }
    }
}
