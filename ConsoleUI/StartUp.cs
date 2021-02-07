using ConsoleUI.EntityTest;
using Core.DependencyResolvers;
using Core.Extensions;
using Core.Utilities.IoC;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ConsoleUI
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        CarilerTest _cariTest;
        StoklarTest _stokTest;
        EvraklarTest _evraklarTest;
        public Startup(CarilerTest cariTest, StoklarTest stokTest, EvraklarTest evraklarTest, IConfiguration configuration)
        {
            this._cariTest = cariTest;
            this._stokTest = stokTest;
            this._evraklarTest = evraklarTest;
            this.Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            //var tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();
            services.AddDependencyResolvers(new ICoreModule[]
            {
                new CoreModule()
            });
            //services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            //    .AddJwtBearer(options =>
            //    {
            //        options.TokenValidationParameters = new TokenValidationParameters()
            //        {
            //            ValidateIssuer = true,
            //            ValidateAudience = true,
            //            ValidateLifetime = true,
            //            ValidIssuer = tokenOptions.Issuer,
            //            ValidAudience = tokenOptions.Audience,
            //            IssuerSigningKey = SecurityKeyHelper.CreateSecurityKey(tokenOptions.SecurityKey)
            //        };
            //    });
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