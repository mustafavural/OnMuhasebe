using ConsoleUI.EntityTest;
using Core.DependencyResolvers;
using Core.Extensions;
using Core.Utilities.IoC;
using Core.Utilities.Security.JWT;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ConsoleUI
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        CarilerTest cariTest;
        StoklarTest stokTest;
        public Startup(CarilerTest cariTest, StoklarTest stokTest, IConfiguration configuration)
        {
            this.cariTest = cariTest;
            this.stokTest = stokTest;
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
            cariTest.SirketTestYap();
            Console.WriteLine("Şirket Testi Bitti");
            Console.ReadLine();

            cariTest.SahisTestYap();
            Console.WriteLine("Şahıs Testi Bitti");
            Console.ReadLine();

            stokTest.StokTestYap();
            Console.WriteLine("Stok Testi Bitti");
            Console.ReadLine();
        }
    }
}