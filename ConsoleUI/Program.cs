using ConsoleUI.EntityTest;
using Core.DependencyResolvers;
using Core.Extensions;
using Core.Utilities.Security.JWT;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ConsoleUI
{
    public class Program
    {
        public IConfiguration Configuration { get; }
        CarilerTest cariTest;
        StoklarTest stokTest;
        public Program(CarilerTest cariTest, StoklarTest stokTest, IConfiguration configuration)
        {
            this.cariTest = cariTest;
            this.stokTest = stokTest;
            this.Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDependencyResolvers(new Core.Utilities.IoC.ICoreModule[]
            {
                new CoreModule(),
            });
        }

        public void Run(string[] args)
        {
            //    cariTest.SirketTestYap();
            //    Console.WriteLine("Şirket Testi Bitti");
            //    Console.ReadLine();

            //    cariTest.SahisTestYap();
            //    Console.WriteLine("Şahıs Testi Bitti");
            //    Console.ReadLine();

            stokTest.StokTestYap();
            Console.WriteLine("Stok Testi Bitti");
            Console.ReadLine();
        }
    }
}