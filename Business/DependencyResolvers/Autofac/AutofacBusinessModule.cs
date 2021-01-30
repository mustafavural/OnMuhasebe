using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Interceptors.Autofac;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StokManager>().As<IStokService>();
            builder.RegisterType<StokGrupManager>().As<IStokGrupService>();
            builder.RegisterType<StokGrupKodManager>().As<IStokGrupKodService>();
            builder.RegisterType<StokHareketManager>().As<IStokHareketService>();

            builder.RegisterType<EFStokDal>().As<IStokDal>();
            builder.RegisterType<EFStokGrupDal>().As<IStokGrupDal>();
            builder.RegisterType<EFStokGrupKodDal>().As<IStokGrupKodDal>();
            builder.RegisterType<EFStokHareketDal>().As<IStokHareketDal>();

            builder.RegisterType<SahisCariManager>().As<ISahisCariService>();
            builder.RegisterType<SirketCariManager>().As<ISirketCariService>();
            builder.RegisterType<CariGrupManager>().As<ICariGrupService>();
            builder.RegisterType<CariGrupKodManager>().As<ICariGrupKodService>();
            builder.RegisterType<CariHareketManager>().As<ICariHareketService>();

            builder.RegisterType<EFCariDal>().As<ICariDal>();
            builder.RegisterType<EFSahisCariDal>().As<ISahisCariDal>();
            builder.RegisterType<EFSirketCariDal>().As<ISirketCariDal>();
            builder.RegisterType<EFCariGrupDal>().As<ICariGrupDal>();
            builder.RegisterType<EFCariGrupKodDal>().As<ICariGrupKodDal>();
            builder.RegisterType<EFCariHareketDal>().As<ICariHareketDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly)
               .AsImplementedInterfaces()
               .EnableInterfaceInterceptors
                (new Castle.DynamicProxy.ProxyGenerationOptions
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}