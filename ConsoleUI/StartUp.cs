using ConsoleUI.EntityTest;
using Core.DependencyResolvers;
using Core.Extensions;
using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ConsoleUI
{
    public class StartUp
    {
        CarilerTest _cariTest;
        StoklarTest _stokTest;
        EvraklarTest _evraklarTest;
        public StartUp(CarilerTest cariTest, StoklarTest stokTest, EvraklarTest evraklarTest)
        {
            this._cariTest = cariTest;
            this._stokTest = stokTest;
            this._evraklarTest = evraklarTest;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDependencyResolvers(new ICoreModule[] { new CoreModule() });
        }
        public void Run()
        {
            _cariTest.SirketTestYap();
            Console.WriteLine("Şirket Testi Bitti");
            Console.ReadLine();

            _cariTest.SahisTestYap();
            Console.WriteLine("Şahıs Testi Bitti");
            Console.ReadLine();

            _stokTest.StokTestYap();
            Console.WriteLine("Stok Testi Bitti");
            Console.ReadLine();

            _evraklarTest.FaturaTestYap();
            Console.WriteLine("Fatura Testi Bitti");
            Console.ReadLine();
        }
    }
}