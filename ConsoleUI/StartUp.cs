using Autofac;
using Business.DependencyResolvers.Autofac;

namespace ConsoleUI
{
    class StartUp
    {
        public static void Main(string[] args)
        {
            var container = ConfigureContainer();
            var application = container.Resolve<Program>();
            application.Run(args);
        }

        private static IContainer ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Program>().AsSelf();
            builder.RegisterModule(new AutofacBusinessModule());

            return builder.Build();
        }
    }
}