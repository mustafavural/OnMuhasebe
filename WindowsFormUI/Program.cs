using Autofac;
using Business.DependencyResolvers.Autofac;
using Core.DependencyResolvers;
using Core.Extensions;
using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using WindowsFormUI.View.Moduls.Stoklar;

namespace WindowsFormUI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var container = ConfigureContainer();
            ConfigureServices(new ServiceCollection());
            Application.Run(container.Resolve<FrmStokListe>());
        }
        private static IContainer ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule(new AutofacBusinessModule());
            builder.RegisterType<FrmStokGrup>().AsSelf();
            builder.RegisterType<FrmStokListe>().AsSelf();

            return builder.Build();
        }
        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddDependencyResolvers(new ICoreModule[] { new CoreModule() });
        }
    }
}
