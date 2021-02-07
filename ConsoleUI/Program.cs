using Autofac;
using Business.DependencyResolvers.Autofac;
using ConsoleUI.EntityTest;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleUI
{
    class Program
    {
        public static void Main()
        {
            var container = ConfigureContainer();
            var program = container.Resolve<Startup>();
            program.ConfigureServices(new ServiceCollection());
            program.Run();
        }
        private static IContainer ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule(new AutofacBusinessModule());
            builder.RegisterType<Startup>().AsSelf();
            builder.RegisterType<ConfigurationRoot>().As<IConfiguration>();
            builder.RegisterType<CarilerTest>().AsSelf();
            builder.RegisterType<StoklarTest>().AsSelf();
            builder.RegisterType<EvraklarTest>().AsSelf();

            return builder.Build();
        }
    }
}